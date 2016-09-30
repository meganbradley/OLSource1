---
title: "CSinusoidalTransitionFromVelocity Class"
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
  - "CSinusoidalTransitionFromVelocity"
  - "afxanimationcontroller/CSinusoidalTransitionFromVelocity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSinusoidalTransitionFromVelocity class"
ms.assetid: cc885f17-b84b-45ee-8f1f-36a8bbb7adad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSinusoidalTransitionFromVelocity Class
Encapsulates a sinusoidal-velocity transition that has an amplitude that is determined by the initial velocity of the animation variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSinusoidalTransitionFromVelocity::CSinusoidalTransitionFromVelocity](#csinusoidaltransitionfromvelocity__csinusoidaltransitionfromvelocity)|Constructs a transition object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSinusoidalTransitionFromVelocity::Create](#csinusoidaltransitionfromvelocity__create)|Calls the transition library to create encapsulated transition COM object. (Overrides [CBaseTransition::Create](../vs140/cbasetransition-class.md#cbasetransition__create).)|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CSinusoidalTransitionFromVelocity::m_duration](#csinusoidaltransitionfromvelocity__m_duration)|The duration of the transition.|  
|[CSinusoidalTransitionFromVelocity::m_period](#csinusoidaltransitionfromvelocity__m_period)|The period of oscillation of the sinusoidal wave in seconds.|  
  
## Remarks  
 The value of the animation variable oscillates around the initial value over the entire duration of a sinusoidal-range transition. The amplitude of the oscillation is determined by the animation variable's velocity when the transition begins. Because all transitions are cleared automatically, it's recommended to allocated them using operator new. The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then it's NULL. Changing member variables after creation of this COM object has no effect.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CSinusoidalTransitionFromVelocity](../vs140/csinusoidaltransitionfromvelocity-class.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="csinusoidaltransitionfromvelocity__create">\</a>  CSinusoidalTransitionFromVelocity::Create  
 Calls the transition library to create encapsulated transition COM object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
### Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
##  \<a name="csinusoidaltransitionfromvelocity__csinusoidaltransitionfromvelocity">\</a>  CSinusoidalTransitionFromVelocity::CSinusoidalTransitionFromVelocity  
 Constructs a transition object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The duration of the transition.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The period of oscillation of the sinusoidal wave in seconds.  
  
##  \<a name="csinusoidaltransitionfromvelocity__m_duration">\</a>  CSinusoidalTransitionFromVelocity::m_duration  
 The duration of the transition.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="csinusoidaltransitionfromvelocity__m_period">\</a>  CSinusoidalTransitionFromVelocity::m_period  
 The period of oscillation of the sinusoidal wave in seconds.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)