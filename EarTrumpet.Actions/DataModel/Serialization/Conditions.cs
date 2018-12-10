﻿using EarTrumpet_Actions.DataModel.Enum;
using System.Xml.Serialization;

namespace EarTrumpet_Actions.DataModel.Serialization
{
    [XmlInclude(typeof(DefaultDeviceCondition))]
    [XmlInclude(typeof(ProcessCondition))]
    [XmlInclude(typeof(VariableCondition))]
    public abstract class BaseCondition : Part { }

    public class DefaultDeviceCondition : BaseCondition, IPartWithDevice
    {
        public Device Device { get; set; }
        public ComparisonBoolKind Option { get; set; }
    }

    public class ProcessCondition : BaseCondition, IPartWithText
    {
        public string PromptText => Properties.Resources.ProcessConditionPromptText;
        public string EmptyText => Properties.Resources.ProcessConditionEmptyText;
        public string Text { get; set; }

        public ProcessStateKind Option { get; set; }
    }

    public class VariableCondition : BaseCondition, IPartWithText
    {
        public string Text { get; set; }
        public BoolValue Value { get; set; }

        public string PromptText => Properties.Resources.VariableConditionPromptText;
        public string EmptyText => Properties.Resources.VariableConditionEmptyText;
    }
}
