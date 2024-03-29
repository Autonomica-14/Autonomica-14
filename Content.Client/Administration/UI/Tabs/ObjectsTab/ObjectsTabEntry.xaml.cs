﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Administration.UI.Tabs.ObjectsTab;

[GenerateTypedNameReferences]
public sealed partial class ObjectsTabEntry : ContainerButton
{
    public NetEntity AssocEntity;

    public ObjectsTabEntry(string name, NetEntity nent)
    {
        RobustXamlLoader.Load(this);
        AssocEntity = nent;
        EIDLabel.Text = nent.ToString();
        NameLabel.Text = name;
    }
}
