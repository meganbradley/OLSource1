---
title: "Setting Control Properties at Design Time"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], properties"
ms.assetid: 963bf498-d371-4cfd-8bed-865427dcfad9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting Control Properties at Design Time
Properties of controls can be set at design time using the Dialog editor. When you set a property, the Resource editor initializes the control with the specified value. The property still can be changed programmatically.  
  
 The **DataSource** property, which is found in all [data-bound controls](../vs140/databinding-with-activex-controls-in-visual-c--.md), allows you to specify the [data source](../vs140/databinding-with-activex-controls-in-visual-c--.md) control to which you want to bind.  
  
 When binding simple bound ADO data-bound controls to an ADO data control (ADODC), you must associate the control with a column by setting the **DataField** property to a valid field in the rowset. Otherwise, the compiled application asserts in a running Debug build (the assertion is simply marking that the control has been bound to a null column).  
  
> [!NOTE]
>  The **General** properties tab allows you to specify a control identifier and other properties needed for the .rc file. (The .rc file is later compiled to generate a Windows program resource code.)  
  
### To set a property on the All tab  
  
1.  [Insert an ActiveX control](../vs140/inserting-the-control-into-a-visual-c---application.md) into a dialog box.  
  
2.  Right-click the control in the Dialog editor, and then click **Properties**.  
  
3.  Click the **All** tab to display the control's properties. For a given property, enter the initialization value.  
  
 To set control properties at run time, see [Modifying a Control's Run-Time Behavior](../vs140/modifying-a-control-s-run-time-behavior.md).  
  
## See Also  
 [Using ActiveX Controls](../vs140/using-activex-controls.md)