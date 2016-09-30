---
title: "CConstantTransition Class"
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
  - "afxanimationcontroller/CConstantTransition"
  - "CConstantTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CConstantTransition class"
ms.assetid: f6fa4780-a71b-4cd6-80aa-d4792ace36c2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConstantTransition Class
Encapsulates a constant transition.  
  
## Syntax  
  
```  
class CConstantTransition : public CBaseTransition;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CConstantTransition::CConstantTransition](#cconstanttransition__cconstanttransition)|Constructs a transition object and initializes its duration.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CConstantTransition::Create](#cconstanttransition__create)|Calls the transition library to create encapsulated transition COM object. (Overrides [CBaseTransition::Create](../vs140/cbasetransition-class.md#cbasetransition__create).)|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CConstantTransition::m_duration](#cconstanttransition__m_duration)|The duration of the transition.|  
  
## Remarks  
 During a constant transition, the value of an animation variable remains at the initial value over the duration of the transition. Because all transitions are cleared automatically, it's recommended to allocated them using operator new. The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then it's NULL. Changing member variables after creation of this COM object has no effect.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CConstantTransition](../vs140/cconstanttransition-class.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="cconstanttransition__cconstanttransition"></a>  CConstantTransition::CConstantTransition  
 Constructs a transition object and initializes its duration.  
  
```  
CConstantTransition (  
   UI_ANIMATION_SECONDS duration  
);  
```  
  
### Parameters  
 `duration`  
 The duration of the transition.  
  
##  \<a name="cconstanttransition__create"></a>  CConstantTransition::Create  
 Calls the transition library to create encapsulated transition COM object.  
  
```  
virtual BOOL Create(  
   IUIAnimationTransitionLibrary* pLibrary,  
   IUIAnimationTransitionFactory* */  
);  
```  
  
### Parameters  
 `pLibrary`  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
### Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
##  \<a name="cconstanttransition__m_duration"></a>  CConstantTransition::m_duration  
 The duration of the transition.  
  
```  
UI_ANIMATION_SECONDS m_duration;  
```  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)