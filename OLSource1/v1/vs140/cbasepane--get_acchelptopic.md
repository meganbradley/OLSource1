---
title: "CBasePane::get_accHelpTopic"
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
  - "CBasePane.get_accHelpTopic"
  - "CBasePane::get_accHelpTopic"
  - "get_accHelpTopic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accHelpTopic method"
ms.assetid: 46c5d590-9c32-42e5-b687-f98008172848
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::get_accHelpTopic
The framework calls this method to retrieve the full path of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> file that is associated with the specified object and the identifier of the appropriate topic in that file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that receives the full path of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> file that is associated with the specified object, if any.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies whether the Help topic to be retrieved is that of the object or one of the child elements of the object. This parameter can be either <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (to obtain a Help topic for the object) or a child ID (to obtain a Help topic for one of the child elements of the object).  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Identifies the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> file topic that is associated with the specified object.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not implement this method. Therefore, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is part of the Active Accessibility support in MFC. Override this function in a derived class to provide help information about your object.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)