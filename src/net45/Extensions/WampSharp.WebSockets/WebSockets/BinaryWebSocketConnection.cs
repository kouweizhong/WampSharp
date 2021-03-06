﻿using System;
using System.Net.WebSockets;
using System.Text;
using WampSharp.Core.Message;
using WampSharp.V2.Authentication;
using WampSharp.V2.Binding;

namespace WampSharp.WebSockets
{
    public class BinaryWebSocketConnection<TMessage> : BinaryWebSocketWrapperConnection<TMessage>
    {
        public BinaryWebSocketConnection(WebSocket webSocket, IWampBinaryBinding<TMessage> binding, ICookieProvider cookieProvider, ICookieAuthenticatorFactory cookieAuthenticatorFactory) : 
            base(new WebSocketWrapper(webSocket), binding, cookieProvider, cookieAuthenticatorFactory)
        {
        }

        protected BinaryWebSocketConnection(ClientWebSocket clientWebSocket, Uri addressUri, IWampBinaryBinding<TMessage> binding) : base(new ClientWebSocketWrapper(clientWebSocket), addressUri, binding)
        {
        }
    }
}