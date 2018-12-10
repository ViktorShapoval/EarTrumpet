﻿using EarTrumpet_Actions.DataModel.Serialization;

namespace EarTrumpet_Actions.ViewModel.Conditions
{
    class VariableConditionViewModel : PartViewModel
    {
        public OptionViewModel Option { get; }
        public TextViewModel Text { get; }

        public VariableConditionViewModel(VariableCondition condition) : base(condition)
        {
            Option = new OptionViewModel(condition, nameof(condition.Value));
            Text = new TextViewModel(condition);

            Attach(Option);
            Attach(Text);
        }
    }
}
