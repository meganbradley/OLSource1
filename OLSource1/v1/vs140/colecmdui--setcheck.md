---
title: "COleCmdUI::SetCheck"
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
  - "COleCmdUI.SetCheck"
  - "COleCmdUI::SetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCheck method"
ms.assetid: a0dd92de-81b3-4141-b68e-1f359a72b52b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCmdUI::SetCheck
Call this function to set the state of an on/off toggle command.  
  
## Syntax  
  
```  
  
      virtual void SetCheck(   
   int nCheck    
);  
```  
  
#### Parameters  
 `nCheck`  
 A value determining the state to set an on/off toggle command. Values are:  
  
|Value|Description|  
|-----------|-----------------|  
|**1**|Sets the command to on.|  
|**2**|Sets the command to indeterminate; the state cannot be determined because the attribute of this command is in both on and off states in the relevant selection.|  
|any other value|Sets the command to off.|  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [COleCmdUI Class](../vs140/colecmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCmdUI::SetText](../vs140/colecmdui--settext.md)