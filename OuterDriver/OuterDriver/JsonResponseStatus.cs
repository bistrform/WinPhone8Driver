﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuterDriver {
    public enum ResponseStatus {
        Sucess = 0,
        NoSuchDriver = 6,
        NoSuchElement = 7,
        NoSuchFrame = 8,
        UnknownCommand = 9,
        StaleElementReference = 10,
        ElementNotVisible = 11,
        InvalidElementState = 12,
        UnknownError = 13,
        ElementIsNotSelectable = 15,
        JavaScriptError = 17,
        XPathLookupError = 19,
        Timeout = 21,
        NoSuchWindow = 23,
        InvalidCookieDomain = 24,
        UnableToSetCookie = 25,
        UnexpectedAlertOpen = 26,
        NoAlertOpenError = 27,
        ScriptTimeout = 28,
        InvalidElementCoordinates = 29,
        IMENotAvailable = 30,
        IMEEngineActivationFailed = 31,
        InvalidSelector = 32,
        SessionNotCreatedException = 33,
        MoveTargetOutOfBounds = 34
    }
}
