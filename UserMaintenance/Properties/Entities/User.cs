﻿using System;

public class User
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public string FullName { get; set; };
    {
        get
        {
            return string.Format(
                "{0} {1}",
                FullName,
                );
        }
    }

    // Ugyanaz a FullName property kompaktabb formában is írható
    /*
    public string FullName
        => string.Format(
            "{0} {1}",
            LastName,
            FirstName);
    */
}

