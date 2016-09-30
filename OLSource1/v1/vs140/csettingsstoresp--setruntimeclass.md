---
title: "CSettingsStoreSP::SetRuntimeClass"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CSettingsStoreSP::SetRuntimeClass"
  - "SetRuntimeClass"
  - "CSettingsStoreSP.SetRuntimeClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRuntimeClass method"
ms.assetid: eb6f0424-bbd3-4635-96d3-308f3372739a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStoreSP::SetRuntimeClass
Sets the runtime class. The method [CSettingsStoreSP::Create](../vs140/csettingsstoresp--create.md) uses the runtime class to determine what type of object to create.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the runtime class information for a class derived from the [CSettingsStore Class](../vs140/csettingsstore-class.md).  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the class identified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not derived from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 You can use the [CSettingsStoreSP Class](../vs140/csettingsstoresp-class.md) to derive classes from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Use the method <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if you want to create objects of a custom class that is derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStoreSP Class](../vs140/csettingsstoresp-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [CSettingsStoreSP::Create](../vs140/csettingsstoresp--create.md)