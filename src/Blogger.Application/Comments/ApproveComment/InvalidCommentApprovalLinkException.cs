﻿using Blogger.Domain.Common.Exceptions;

namespace Blogger.Application.Comments.ApproveComment;

public class InvalidCommentApprovalLinkException : DomainException
{
    private const string _message = "Invalid comment approved link.";
    public InvalidCommentApprovalLinkException() : base(_message)
    {
    }
}
