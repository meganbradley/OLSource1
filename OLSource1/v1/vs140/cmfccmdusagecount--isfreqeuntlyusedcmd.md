---
title: "CMFCCmdUsageCount::IsFreqeuntlyUsedCmd"
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
  - "CMFCCmdUsageCount.IsFreqeuntlyUsedCmd"
  - "IsFreqeuntlyUsedCmd"
  - "CMFCCmdUsageCount::IsFreqeuntlyUsedCmd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFreqeuntlyUsedCmd method"
ms.assetid: 23fe4d3f-079e-4a15-a80c-f0b37e0bf045
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCmdUsageCount::IsFreqeuntlyUsedCmd
Determines whether the given command is frequently used.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Specifies the command to check.|  
  
## Return Value  
 Nonzero if the command is frequently used; otherwise 0.  
  
## Remarks  
 This method returns 0 if the total command usage, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, is 0. Otherwise, this method returns nonzero if the percentage of which the specified command is used is larger than the minimum percentage, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. By default, the framework sets the minimum percentage to 5. You can override this value by using the [CMFCCmdUsageCount::SetOptions](../vs140/cmfccmdusagecount--setoptions.md) method. If the minimum percentage is 0, this method returns nonzero if the specified command count is larger than 0.  
  
 [CMFCToolBar::IsCommandRarelyUsed](../vs140/cmfctoolbar--iscommandrarelyused.md) uses this method to determine whether a command is rarely used.  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
## See Also  
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCmdUsageCount::SetOptions](../vs140/cmfccmdusagecount--setoptions.md)   
 [CMFCToolBar::IsCommandRarelyUsed](../vs140/cmfctoolbar--iscommandrarelyused.md)