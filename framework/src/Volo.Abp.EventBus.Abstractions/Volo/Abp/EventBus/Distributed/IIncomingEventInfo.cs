using System;
using Volo.Abp.Data;

namespace Volo.Abp.EventBus.Distributed;

public interface IIncomingEventInfo : IHasExtraProperties
{
    public Guid Id { get; }

    public string MessageId { get; }

    public string EventName { get; }

    public byte[] EventData { get; }

    public DateTime CreationTime { get; }
}
