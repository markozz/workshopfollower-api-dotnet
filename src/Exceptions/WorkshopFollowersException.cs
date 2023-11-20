using System;

namespace Provider.Exceptions;

public class WorkshopFollowersException: Exception
{

    private String _message;
    private int _statusCode;

    public WorkshopFollowersException()
    {
        this._message = "Not Found";
        this._statusCode = 404;
    }

    public String GetMessage()
    {
        return this._message;
    }

    public int GetStatusCode()
    {
        return this._statusCode;
    }
}