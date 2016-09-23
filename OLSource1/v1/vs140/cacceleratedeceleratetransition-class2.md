---
title: "CAccelerateDecelerateTransition Class2"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
H1: CAccelerateDecelerateTransition Class
ms.assetid: 97d4cdb9-84ed-44ca-8a31-2a0f4ee07ed4
caps.latest.revision: 9
---
# CAccelerateDecelerateTransition Class2
Implements an accelerate-decelerate transition.  
  
## Syntax  
  
```  
class CAccelerateDecelerateTransition : public CBaseTransition;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAccelerateDecelerateTransition::CAccelerateDecelerateTransition](../vs140/cacceleratedeceleratetransition--cacceleratedeceleratetransition.md)|Constructs a transition object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAccelerateDecelerateTransition::Create](../vs140/cacceleratedeceleratetransition--create.md)|Calls the transition library to create encapsulated transition COM object. (Overrides                                         [CBaseTransition::Create](../vs140/cbasetransition--create.md).)|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAccelerateDecelerateTransition::m_accelerationRatio](../vs140/cacceleratedeceleratetransition--m_accelerationratio.md)|The ratio of the time spent accelerating to the duration.|  
|[CAccelerateDecelerateTransition::m_decelerationRatio](../vs140/cacceleratedeceleratetransition--m_decelerationratio.md)|The ratio of the time spent decelerating to the duration.|  
|[CAccelerateDecelerateTransition::m_duration](../vs140/cacceleratedeceleratetransition--m_duration.md)|The duration of the transition.|  
|[CAccelerateDecelerateTransition::m_finalValue](../vs140/cacceleratedeceleratetransition--m_finalvalue.md)|The value of the animation variable at the end of the transition.|  
  
## Remarks  
 During an accelerate-decelerate transition, the animation variable speeds up and then slows down over the duration of the transition, ending at a specified value. You can control how quickly the variable accelerates and decelerates independently, by specifying different acceleration and deceleration ratios. When the initial velocity is zero, the acceleration ratio is the fraction of the duration that the variable will spend accelerating; likewise with the deceleration ratio. If the initial velocity is non-zero, it is the fraction of the time between the velocity reaching zero and the end of transition. The acceleration ratio and the deceleration ratio should sum to a maximum of 1.0. Because all transitions are cleared automatically, it's recommended to allocated them using operator new. The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then it's NULL. Changing member variables after creation of this COM object has no effect.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CAccelerateDecelerateTransition](../vs140/cacceleratedeceleratetransition-class1.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## Members  
  
###  <a name="CAccelerateDecelerateTransition__CAccelerateDecelerateTransition"></a> CAccelerateDecelerateTransition::CAccelerateDecelerateTransition  
 Constructs a transition object.  
  
```  
CAccelerateDecelerateTransition(  
   UI_ANIMATION_SECONDS                         duration,  
   DOUBLE                         finalValue,  
   DOUBLE                         accelerationRatio = 0.3,  
   DOUBLE                         decelerationRatio = 0.3  
);  
```  
  
#### Parameters  
 `duration`  
 The duration of the transition.  
  
 `finalValue`  
 The value of the animation variable at the end of the transition.  
  
 `accelerationRatio`  
 The ratio of the time spent accelerating to the duration.  
  
 `decelerationRatio`  
 The ratio of the time spent decelerating to the duration.  
  
###  <a name="CAccelerateDecelerateTransition__Create"></a> CAccelerateDecelerateTransition::Create  
 Calls the transition library to create encapsulated transition COM object.  
  
```  
virtual BOOL Create(  
   IUIAnimationTransitionLibrary*                         pLibrary,  
   IUIAnimationTransitionFactory* */  
);  
```  
  
#### Parameters  
 `pLibrary`  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
#### Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
###  <a name="CAccelerateDecelerateTransition__m_accelerationRatio"></a> CAccelerateDecelerateTransition::m_accelerationRatio  
 The ratio of the time spent accelerating to the duration.  
  
```  
DOUBLE m_accelerationRatio;  
```  
  
###  <a name="CAccelerateDecelerateTransition__m_decelerationRatio"></a> CAccelerateDecelerateTransition::m_decelerationRatio  
 The ratio of the time spent decelerating to the duration.  
  
```  
DOUBLE m_decelerationRatio;  
```  
  
###  <a name="CAccelerateDecelerateTransition__m_duration"></a> CAccelerateDecelerateTransition::m_duration  
 The duration of the transition.  
  
```  
UI_ANIMATION_SECONDS m_duration;  
```  
  
###  <a name="CAccelerateDecelerateTransition__m_finalValue"></a> CAccelerateDecelerateTransition::m_finalValue  
 The value of the animation variable at the end of the transition.  
  
```  
DOUBLE m_finalValue;  
```  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)