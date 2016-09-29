---
title: "CReversalTransition Class"
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
  - "afxanimationcontroller/CReversalTransition"
  - "CReversalTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReversalTransition class"
ms.assetid: e89516be-2d07-4885-95a8-fc278f46e3ad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReversalTransition Class
Encapsulates a reversal transition.  
  
## Syntax  
  
```  
class CReversalTransition : public CBaseTransition;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CReversalTransition::CReversalTransition](#creversaltransition__creversaltransition)|Constructs a reversal transition object and initializes its duration.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CReversalTransition::Create](#creversaltransition__create)|Calls the transition library to create encapsulated transition COM object. (Overrides [CBaseTransition::Create](../vs140/cbasetransition-class.md#cbasetransition__create).)|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CReversalTransition::m_duration](#creversaltransition__m_duration)|The duration of the transition.|  
  
## Remarks  
 A reversal transition smoothly changes direction over a given duration. The final value will be the same as the initial value and the final velocity will be the negative of the initial velocity. Because all transitions are cleared automatically, it's recommended to allocated them using operator new. The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then it's NULL. Changing member variables after creation of this COM object has no effect.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CReversalTransition](../vs140/creversaltransition-class.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  <a name="creversaltransition__create"></a>  CReversalTransition::Create  
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
  
##  <a name="creversaltransition__creversaltransition"></a>  CReversalTransition::CReversalTransition  
 Constructs a reversal transition object and initializes its duration.  
  
```  
CReversalTransition(  
   UI_ANIMATION_SECONDS duration  
);  
```  
  
### Parameters  
 `duration`  
 The duration of the transition.  
  
##  <a name="creversaltransition__m_duration"></a>  CReversalTransition::m_duration  
 The duration of the transition.  
  
```  
UI_ANIMATION_SECONDS m_duration;  
```  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)