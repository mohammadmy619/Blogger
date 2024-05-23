﻿using Blogger.Domain.Common.Exceptions;

namespace Blogger.Application.Comments.MakeComment;

public class NotValidClientException : DomainException
{
    private const string _messages = "Invalid client id.";

    public NotValidClientException() : base(_messages)
    {

    }
}