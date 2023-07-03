﻿namespace Dr.Logging.Abstractions;

internal interface IStructLogProcessor
{
    void AddLog(StructLog structLog);

    void ConsolePrint(StructLog structLog);

    void ConsumerLog();
}