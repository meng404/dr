﻿using Microsoft.Extensions.Logging;

namespace Dr.Logging.Abstractions;
internal interface IStructLogBuilder
{
    StructLog Build<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter);
}