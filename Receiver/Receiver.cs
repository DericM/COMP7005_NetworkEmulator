using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TcpLib;

namespace Receiver
{
    public class Receiver : TcpServiceProvider
    {
        private string _receivedStr;

        public override object Clone()
        {
            return new Receiver();
        }

        public override void OnAcceptConnection(ConnectionState state)
        {
            _receivedStr = "";
            if (!state.Write(Encoding.UTF8.GetBytes("Hello World!\r\n"), 0, 14))
                state.EndConnection();

            //if write fails... then close connection
        }


        public override void OnReceiveData(ConnectionState state)
        {

            byte[] buffer = new byte[1024];
            while (state.AvailableData > 0)
            {
                int readBytes = state.Read(buffer, 0, 1024);
                if (readBytes > 0)
                {
                    _receivedStr += Encoding.UTF8.GetString(buffer, 0, readBytes);
                    if (_receivedStr.IndexOf("<EOF>") >= 0)
                    {



                        if (_receivedStr.IndexOf("<FILENAME>") >= 0)
                        {
                            int headerStart = _receivedStr.IndexOf("<FILENAME>");
                            int filenameStart = headerStart + 10;
                            int filenameEnd = _receivedStr.IndexOf("</FILENAME>");
                            int headerEnd = filenameEnd + 11;
                            int filenameLength = filenameEnd - filenameStart;

                            String filename = _receivedStr.Substring(filenameStart, filenameLength);
                            getFileForSendingToClient(filename);

                            int eofEnd = _receivedStr.IndexOf("<EOF>") + 4;
                            _receivedStr = _receivedStr.Remove(0, eofEnd);
                        }

                        if (_receivedStr.IndexOf("<FILELIST>") >= 0)
                        {
                            sendFileList(state);
                            int eofEnd = _receivedStr.IndexOf("<EOF>") + 4;
                            _receivedStr = _receivedStr.Remove(0, eofEnd);
                        }
                        

                    }
                }
                else state.EndConnection(); //If read fails then close connection
            }
        }

        

        public override void OnDropConnection(ConnectionState state)
        {
            //Nothing to clean here
        }
    }
}
