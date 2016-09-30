---
title: "CLinearTransition Class"
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
  - "CLinearTransition"
  - "afxanimationcontroller/CLinearTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLinearTransition class"
ms.assetid: 7fcb2dba-beb8-4933-9f5d-3b7fb1585ef0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinearTransition Class
Encapsulates a linear transition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CLinearTransition::CLinearTransition](#clineartransition__clineartransition)|Constructs a linear transition object and initializes it with duration and final value.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CLinearTransition::Create](#clineartransition__create)|Calls the transition library to create encapsulated transition COM object. (Overrides [CBaseTransition::Create](../vs140/cbasetransition-class.md#cbasetransition__create).)|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CLinearTransition::m_dblFinalValue](#clineartransition__m_dblfinalvalue)|The value of the animation variable at the end of the transition.|  
|[CLinearTransition::m_duration](#clineartransition__m_duration)|The duration of the transition.|  
  
## Remarks  
 During a linear transition, the value of the animation variable transitions linearly from its initial value to a specified final value. Because all transitions are cleared automatically, it's recommended to allocated them using operator new. The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then it's NULL. Changing member variables after creation of this COM object has no effect.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CLinearTransition](../vs140/clineartransition-class.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="clineartransition__clineartransition">\</a>  CLinearTransition::CLinearTransition  
 Constructs a linear transition object and initializes it with duration and final value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The duration of the transition.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The value of the animation variable at the end of the transition.  
  
##  \<a name="clineartransition__create">\</a>  CLinearTransition::Create  
 Calls the transition library to create encapsulated transition COM object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
### Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
##  \<a name="clineartransition__m_dblfinalvalue">\</a>  CLinearTransition::m_dblFinalValue  
 The value of the animation variable at the end of the transition.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="clineartransition__m_duration">\</a>  CLinearTransition::m_duration  
 The duration of the transition.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)