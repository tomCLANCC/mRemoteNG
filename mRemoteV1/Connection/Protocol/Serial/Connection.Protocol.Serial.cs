namespace mRemoteNG.Connection.Protocol.Serial
{
    public class ProtocolSerial : PuttyBase
    {
        public ProtocolSerial()
        {
            this.PuttyProtocol = Putty_Protocol.serial;
        }
    }
}