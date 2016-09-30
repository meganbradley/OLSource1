---
title: "CMFCCmdUsageCount::SetOptions"
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
  - "CMFCCmdUsageCount::SetOptions"
  - "SetOptions"
  - "CMFCCmdUsageCount.SetOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOptions method"
ms.assetid: 10afe085-4c02-4166-afdf-d77959f01c87
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCmdUsageCount::SetOptions
Sets the values of shared <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class data members.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The new initial count of all tracked commands.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The new minimum usage percentage.|  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the method succeeds, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is larger than or equal to 100.  
  
## Remarks  
 This method sets the shared <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class data members <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, respectively. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used by the [CMFCCmdUsageCount::HasEnoughInformation](../vs140/cmfccmdusagecount--hasenoughinformation.md) method to determine whether this object has collected the minimum amount of tracking data. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is used by the [CMFCCmdUsageCount::IsFreqeuntlyUsedCmd](../vs140/cmfccmdusagecount--isfreqeuntlyusedcmd.md) method to determine whether a given command is frequently used.  
  
 In Debug builds this method generates an assertion failure if the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter is larger than or equal to 100.  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
## See Also  
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCmdUsageCount::HasEnoughInformation](../vs140/cmfccmdusagecount--hasenoughinformation.md)   
 [CMFCCmdUsageCount::IsFreqeuntlyUsedCmd](../vs140/cmfccmdusagecount--isfreqeuntlyusedcmd.md)