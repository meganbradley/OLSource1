---
title: "CRBTree::CPair Class"
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
  - "CRBTree::CPair"
  - "CRBTree.CPair"
  - "ATL::CRBTree::CPair"
  - "ATL.CRBTree.CPair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPair class"
  - "CPair class, data members"
  - "CPair class, members"
ms.assetid: 35e224ed-407e-4864-90ee-2dac2432ad41
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::CPair Class
A class containing the key and value elements.  
  
## Syntax  
  
```  
  
class CPair : public __POSITION  
  
```  
  
## Remarks  
 This class is used by the methods [CRBTree::GetAt](../vs140/crbtree--getat.md), [CRBTree::GetNext](../vs140/crbtree--getnext.md), and [CRBTree::GetPrev](../vs140/crbtree--getprev.md) to access the key and value elements stored in the tree structure.  
  
 The members are as follows:  
  
|||  
|-|-|  
|[m_key](../vs140/catlmap--cpair--m_key.md)|The data member storing the key element.|  
|[m_value](../vs140/catlmap--cpair--m_value.md)|The data member storing the value element.|  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)