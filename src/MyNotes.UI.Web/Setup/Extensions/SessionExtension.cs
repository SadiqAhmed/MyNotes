namespace MyNotes.UI.Web.Setup.Extensions
{
    using System.Web;
    using MyNotes.UI.Web.Setup.Common;

    public static class SessionExtension
    {
        public static void SetValue(this HttpSessionStateBase session, SessionKey sessionKey, object value)
        {
            session[sessionKey.ToString()] = value;
        }

        public static T GetValue<T>(this HttpSessionStateBase session, SessionKey sessionKey)
        {
            return GetValue<T>(session, sessionKey, default(T));
        }

        public static T GetValue<T>(this HttpSessionStateBase session, SessionKey sessionKey, T value)
        {
            if (session[sessionKey.ToString()] == null)
                return value;

            return (T)session[sessionKey.ToString()];
        }

        public static bool Exists<T>(this HttpSessionStateBase session, SessionKey sessionKey)
        {
            return (session[sessionKey.ToString()] != null);
        }

        public static void RemoveValue(this HttpSessionStateBase session, params SessionKey[] sessionKeys)
        {
            foreach (var sessionKey in sessionKeys)
                session.Remove(sessionKey.ToString());
        }
    }
}