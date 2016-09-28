---
title: "CMFCCmdUsageCount::HasEnoughInformation"
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
  - "CMFCCmdUsageCount::HasEnoughInformation"
  - "HasEnoughInformation"
  - "CMFCCmdUsageCount.HasEnoughInformation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HasEnoughInformation method"
ms.assetid: ac415454-61d3-420d-9f51-453af6914464
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCmdUsageCount::HasEnoughInformation
Determines whether this object has received the minimum amount of tracking data.  
  
## Syntax  
  
```  
BOOL HasEnoughInformation() const;  
```  
  
## Return Value  
 Nonzero if this object has received the minimum amount of tracking data; otherwise 0.  
  
## Remarks  
 This method returns a nonzero value if the total count, `m_nTotalUsage`, of all tracked commands is equal to or larger than the initial count, `m_nStartCount`. By default, the framework sets the initial count 0. You can override this value by using the [CMFCCmdUsageCount::SetOptions](../vs140/cmfccmdusagecount--setoptions.md) method.  
  
 This method is used by [CMFCMenuBar::IsShowAllCommands](../vs140/cmfcmenubar--isshowallcommands.md) to determine whether to show all available menu commands.  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
## See Also  
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCmdUsageCount::SetOptions](../vs140/cmfccmdusagecount--setoptions.md)   
 [CMFCMenuBar::IsShowAllCommands](../vs140/cmfcmenubar--isshowallcommands.md)