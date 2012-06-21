﻿namespace MyNotes.Services.Contracts
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Ping();
    }
}
