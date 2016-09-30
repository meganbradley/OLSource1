---
title: "CBaseTabbedPane::FloatTab"
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
  - "FloatTab"
  - "CBaseTabbedPane::FloatTab"
  - "CBaseTabbedPane.FloatTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FloatTab method"
ms.assetid: 3c7038c3-db56-407e-a0e9-b7c1890235b2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::FloatTab
Floats a pane, but only if the pane currently resides in a detachable tab.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to float.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the tab to float.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the method to use to make the pane float. For more information, see the Remarks section.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to hide the pane before floating; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the pane floated; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to float a pane that currently resides in a detachable tab.  
  
 If you want to detach a pane programmatically, specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter. If you want to float the pane in the same position where it floated previously, specify <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)