---
title: "CTreeCtrl::EndEditLabelNow"
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
  - "CTreeCtrl::EndEditLabelNow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndEditLabelNow method"
ms.assetid: 43eeef8f-001c-42f4-8cc8-3130127db0e6
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::EndEditLabelNow
Concludes the edit operation on the label of a tree-view item in the current tree-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to discard changes to the tree-view item before concluding the edit operation, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to save changes to the tree-view item before concluding the operation.|  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method sends the [TVM_ENDEDITLABELNOW](http://msdn.microsoft.com/library/windows/desktop/bb773564) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows NT 3.51 and later.  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_ENDEDITLABELNOW](http://msdn.microsoft.com/library/windows/desktop/bb773564)   
 [CTreeCtrl::EditLabel](../vs140/ctreectrl--editlabel.md)