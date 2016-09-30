---
title: "CCmdTarget::EnableAutomation"
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
  - "CCmdTarget.EnableAutomation"
  - "CCmdTarget::EnableAutomation"
  - "EnableAutomation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCmdTarget class, operations"
  - "EnableAutomation method"
ms.assetid: d71526d5-e481-4367-a937-b8c959cd43e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::EnableAutomation
Call this function to enable OLE automation for an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This function is typically called from the constructor of your object and should only be called if a dispatch map has been declared for the class. For more information on automation see the articles [Automation Clients](../vs140/automation-clients.md) and [Automation Servers](../vs140/automation-servers.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DECLARE_OLECREATE](../vs140/declare_olecreate.md)