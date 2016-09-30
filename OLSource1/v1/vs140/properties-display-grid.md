---
title: "Properties Display Grid"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "properties [Visual Studio SDK], grid"
ms.assetid: 318e41b0-acf5-4842-b85e-421c9d5927c5
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Properties Display Grid
The **Properties** window displays fields within a grid. The left column contains the property names; the right column contains the property values.  
  
## Working with the Grid  
 The two-column list shows configuration-independent properties that can be changed at design time and their current settings. Note that all properties might not be shown. A property can be set as hidden, for example, by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.HideProperty*> method. Specifically, to hide properties that have child properties see, [Hiding Properties That Have Child Properties](../vs140/hiding-properties-that-have-child-properties.md).  
  
 To push information to the **Properties** window, the IDE uses \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*>. \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*> is called by VSPackages for each window that contains selectable objects with related properties to be displayed in the **Properties** window. **Solution Explorer**'s implementation of \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*> calls <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> using \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_BrowseObject*> in your project hierarchy to acquire the browseable objects in the hierarchy.  
  
 If your VSPackage does not support \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_BrowseObject*>, the IDE attempts to use \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty*> using the value for \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_SelContainer*> that the hierarchy item or items supply.  
  
 Your project VSPackage does not need to create \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*> because the IDE-supplied window package that implements it (for example, **Solution Explorer**) constructs \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*> on its behalf.  
  
 \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer*> consists of three methods that are called by the IDE:  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.CountObjects*> contains the number of objects selected to be displayed in the **Properties** window.  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.GetObjects*> returns the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects that are selected to be displayed in the **Properties** window.  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.SelectObjects*> makes it possible for any of the objects returned by \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.GetObjects*> to be selected by the user. This allows the VSPackage to visually update the selection displayed to the user in the UI.  
  
 The **Properties** window extracts information from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects to retrieve the properties being browsed. The Properties browser uses <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to ask the object what properties it supports by querying <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which is obtained from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The browser then uses these values to populate the **Properties** window and change the values for individual properties displayed in the grid. The properties information is maintained within the object itself.  
  
 Because the returned objects support <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the caller can obtain information such as the object's name by calling either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with a predefined dispatch identifier (DISPID) that represents the desired information. Declared DISPIDs are negative to ensure they do not conflict with user-defined identifiers.  
  
 The **Properties** window displays different types of fields depending on the attributes of specific properties of a selected object. These fields include edit boxes, drop-down lists, and links to custom editor dialog boxes.  
  
-   Values contained in an enumerated list are retrieved by a \<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.GetObjects*> query to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Values obtained from an enumerated list can be changed in the properties grid by double-clicking the field name, or by clicking the value and selecting the new value from the drop-down list. For properties that have predefined settings from enumerated lists, double-clicking the property name in the Properties list cycles through the available choices. For predefined properties with only two choices, such as true/false, double-click the property name to switch between the choices.  
  
-   If \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.HasDefaultValue*> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, indicating that the value has been changed, the value is displayed in bold text. \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.CanResetPropertyValue*> is used to determine if the value can be reset to the original value. If so, you can change back to the default by right-clicking the value and choosing **Reset** from the menu displayed. Otherwise, you have to change the value back to the default manually. \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing*> also allows you to localize and hide the names of properties displayed during design time, but does not affect the property names displayed during run time.  
  
-   Clicking the ellipsis (...) button displays a list of property values from which the user can select (such as a color picker or font list). \<xref:Microsoft.VisualStudio.Shell.Interop.IProvidePropertyBuilder*> provides these values.  
  
## See Also  
 [Extending Properties](../vs140/extending-properties.md)