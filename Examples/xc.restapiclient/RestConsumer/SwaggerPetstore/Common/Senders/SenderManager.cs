﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.SwaggerPetstore.Common;

namespace XComponent.SwaggerPetstore.Common.Senders
{
    public class SenderManager
    {
		private static InitDefaultEventOnUpSwaggerPetstoreSender _initDefaultEventOnUpSwaggerPetstoreSender;
		private static AddPetAddPetOnUpSwaggerPetstoreSender _addPetAddPetOnUpSwaggerPetstoreSender;
		private static GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender _getPetByIdGetPetByIdOnUpSwaggerPetstoreSender;
		private static CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender _createAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender;
		private static CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender _createGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender;

        public static InitDefaultEventOnUpSwaggerPetstoreSender InitDefaultEventOnUpSwaggerPetstoreSender
        {
            get
            {
                return _initDefaultEventOnUpSwaggerPetstoreSender ??
                       (_initDefaultEventOnUpSwaggerPetstoreSender = new InitDefaultEventOnUpSwaggerPetstoreSender());
            }
        }

        public static AddPetAddPetOnUpSwaggerPetstoreSender AddPetAddPetOnUpSwaggerPetstoreSender
        {
            get
            {
                return _addPetAddPetOnUpSwaggerPetstoreSender ??
                       (_addPetAddPetOnUpSwaggerPetstoreSender = new AddPetAddPetOnUpSwaggerPetstoreSender());
            }
        }

        public static GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender
        {
            get
            {
                return _getPetByIdGetPetByIdOnUpSwaggerPetstoreSender ??
                       (_getPetByIdGetPetByIdOnUpSwaggerPetstoreSender = new GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender());
            }
        }

        public static CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender
        {
            get
            {
                return _createAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender ??
                       (_createAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender = new CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender());
            }
        }

        public static CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender
        {
            get
            {
                return _createGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender ??
                       (_createGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender = new CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender());
            }
        }

    }
}
