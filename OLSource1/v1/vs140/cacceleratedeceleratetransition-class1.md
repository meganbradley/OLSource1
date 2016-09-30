---
title: "CAccelerateDecelerateTransition Class1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "CAccelerateDecelerateTransition Class"
f1_keywords: 
  - "CAccelerateDecelerateTransition"
  - "afxanimationcontroller/CAccelerateDecelerateTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAccelerateDecelerateTransition class"
ms.assetid: b1f31ee8-bb11-4ccc-b124-365fb02b025c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccelerateDecelerateTransition Class1
Implements an accelerate-decelerate transition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAccelerateDecelerateTransition::CAccelerateDecelerateTransition](#cacceleratedeceleratetransition__cacceleratedeceleratetransition)|Constructs a transition object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAccelerateDecelerateTransition::Create](#cacceleratedeceleratetransition__create)|Calls the transition library to create encapsulated transition COM object. (Overrides [CBaseTransition::Create](../vs140/cbasetransition-class.md#cbasetransition__create).)|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAccelerateDecelerateTransition::m_accelerationRatio](#cacceleratedeceleratetransition__m_accelerationratio)|The ratio of the time spent accelerating to the duration.|  
|[CAccelerateDecelerateTransition::m_decelerationRatio](#cacceleratedeceleratetransition__m_decelerationratio)|The ratio of the time spent decelerating to the duration.|  
|[CAccelerateDecelerateTransition::m_duration](#cacceleratedeceleratetransition__m_duration)|The duration of the transition.|  
|[CAccelerateDecelerateTransition::m_finalValue](#cacceleratedeceleratetransition__m_finalvalue)|The value of the animation variable at the end of the transition.|  
  
## Remarks  
 During an accelerate-decelerate transition, the animation variable speeds up and then slows down over the duration of the transition, ending at a specified value. You can control how quickly the variable accelerates and decelerates independently, by specifying different acceleration and deceleration ratios. When the initial velocity is zero, the acceleration ratio is the fraction of the duration that the variable will spend accelerating; likewise with the deceleration ratio. If the initial velocity is non-zero, it is the fraction of the time between the velocity reaching zero and the end of transition. The acceleration ratio and the deceleration ratio should sum to a maximum of 1.0. Because all transitions are cleared automatically, it's recommended to allocated them using operator new. The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then it's NULL. Changing member variables after creation of this COM object has no effect.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CAccelerateDecelerateTransition](../vs140/cacceleratedeceleratetransition-class1.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="cacceleratedeceleratetransition__cacceleratedeceleratetransition">\</a>  CAccelerateDecelerateTransition::CAccelerateDecelerateTransition  
 Constructs a transition object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The duration of the transition.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The value of the animation variable at the end of the transition.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The ratio of the time spent accelerating to the duration.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The ratio of the time spent decelerating to the duration.  
  
##  \<a name="cacceleratedeceleratetransition__create">\</a>  CAccelerateDecelerateTransition::Create  
 Calls the transition library to create encapsulated transition COM object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
### Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
##  \<a name="cacceleratedeceleratetransition__m_accelerationratio">\</a>  CAccelerateDecelerateTransition::m_accelerationRatio  
 The ratio of the time spent accelerating to the duration.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cacceleratedeceleratetransition__m_decelerationratio">\</a>  CAccelerateDecelerateTransition::m_decelerationRatio  
 The ratio of the time spent decelerating to the duration.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cacceleratedeceleratetransition__m_duration">\</a>  CAccelerateDecelerateTransition::m_duration  
 The duration of the transition.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cacceleratedeceleratetransition__m_finalvalue">\</a>  CAccelerateDecelerateTransition::m_finalValue  
 The value of the animation variable at the end of the transition.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)