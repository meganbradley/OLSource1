---
title: "Tabs and Tab Control Attributes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - attributes [C++], reference topics
  - tab controls, attributes
  - tabs
  - tabs, attributes
  - CTabCtrl class, tab control attributes
ms.assetid: ecf190cb-f323-4751-bfdb-766dbe6bb553
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Tabs and Tab Control Attributes
You have considerable control over the appearance and behavior of tabs that make up a tab control ([CTabCtrl](../vs140/ctabctrl-class.md)). Each tab can have a label, an icon, an item state, and an application-defined 32-bit value associated with it. For each tab, you can display the icon, the label, or both.  
  
 In addition, each tab item can have three possible states: pressed, unpressed, or highlighted. This state can only be set by modifying an existing tab item. To modify an existing tab item, retrieve it with a call to [GetItem](../vs140/ctabctrl--getitem.md), modify the `TCITEM` structure (specifically the **dwState** and **dwStateMask** data members), and then return the modified `TCITEM` structure with a call to [SetItem](../vs140/ctabctrl--setitem.md). If you need to clear the item states of all the tab items in a `CTabCtrl` object, make a call to [DeselectAll](../vs140/ctabctrl--deselectall.md). This function resets the state of all tab items or all items except the one currently selected.  
  
 The following code clears the state of all tab items and then modifies the state of the third item:  
  
 [!code[NVC_MFCControlLadenDialog#32](../vs140/codesnippet/CPP/tabs-and-tab-control-attributes_1.cpp)]
  
  
 For more information about tab attributes, see [Tabs and Tab Attributes](http://msdn.microsoft.com/library/windows/desktop/bb760550) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about adding tabs to a tab control, see [Adding Tabs to a Tab Control](../vs140/adding-tabs-to-a-tab-control.md) later in this topic.  
  
## See Also  
 [Using CTabCtrl](../vs140/using-ctabctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)