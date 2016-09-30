---
title: "CCustomTransition Class"
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
  - "afxanimationcontroller/CCustomTransition"
  - "CCustomTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCustomTransition class"
ms.assetid: 5bd3f492-940f-4290-a38b-fa68eb8f8401
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomTransition Class
Implements a custom transition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCustomTransition::CCustomTransition](#ccustomtransition__ccustomtransition)|Constructs a custom transition object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCustomTransition::Create](#ccustomtransition__create)|Calls the transition library to create encapsulated transition COM object. (Overrides [CBaseTransition::Create](../vs140/cbasetransition-class.md#cbasetransition__create).)|  
|[CCustomTransition::SetInitialValue](#ccustomtransition__setinitialvalue)|Sets an initial value, which will be applied to an animation variable associated with this transition.|  
|[CCustomTransition::SetInitialVelocity](#ccustomtransition__setinitialvelocity)|Sets an initial velocity, which will be applied to an animation variable associated with this transition.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CCustomTransition::m_bInitialValueSpecified](#ccustomtransition__m_binitialvaluespecified)|Specifies whether the initial value was specified with SetInitialValue.|  
|[CCustomTransition::m_bInitialVelocitySpecified](#ccustomtransition__m_binitialvelocityspecified)|Specifies whether the initial velocity was specified with SetInitialVelocity.|  
|[CCustomTransition::m_initialValue](#ccustomtransition__m_initialvalue)|Stores the initial value.|  
|[CCustomTransition::m_initialVelocity](#ccustomtransition__m_initialvelocity)|Stores the initial velocity.|  
|[CCustomTransition::m_pInterpolator](#ccustomtransition__m_pinterpolator)|Stores a pointer to a custom interpolator.|  
  
## Remarks  
 The CCustomTransitions class allows developers to implement custom transitions. It's created and used as a standard transition, but its constructor accepts as parameter a pointer to a custom interpolator. Perform the following steps to use custom transitions: 1. Derive a class from CCustomInterpolator and implement at least InterpolateValue method. 2. Ensure that the lifetime of custom interpolator object must be longer than duration of animation where it's used. 3. Instantiate (using operator new) a CCustomTransition object and pass a pointer to custom interpolator in the constructor. 4. Call CCustomTransition::SetInitialValue and CCustomTransition::SetInitialVelocity if these parameters are required for custom interpolation. 5. Pass the pointer to custom transition to AddTransition method of animation object, whose value should be animated with the custom algorithm. 6. When the value of animation object should change Windows Animation API will call InterpolateValue (and other relevant methods) in CCustomInterpolator.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CBaseTransition](../vs140/cbasetransition-class.md)  
  
 [CCustomTransition](../vs140/ccustomtransition-class.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="ccustomtransition__ccustomtransition">\</a>  CCustomTransition::CCustomTransition  
 Constructs a custom transition object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to custom interpolator.  
  
##  \<a name="ccustomtransition__create">\</a>  CCustomTransition::Create  
 Calls the transition library to create encapsulated transition COM object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to transition factory, which is responsible for creation of custom transitions.  
  
### Return Value  
  
### Remarks  
 This method also can set initial value and initial velocity to be applied to an animation variable, which is associated with this transition. For this purpose you have to call SetInitialValue and SetInitialVelocity before the framework creates the encapsulated transition COM object (it happens when you call CAnimationController::AnimateGroup).  
  
##  \<a name="ccustomtransition__m_binitialvaluespecified">\</a>  CCustomTransition::m_bInitialValueSpecified  
 Specifies whether the initial value was specified with SetInitialValue.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="ccustomtransition__m_binitialvelocityspecified">\</a>  CCustomTransition::m_bInitialVelocitySpecified  
 Specifies whether the initial velocity was specified with SetInitialVelocity.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ccustomtransition__m_initialvalue">\</a>  CCustomTransition::m_initialValue  
 Stores the initial value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="ccustomtransition__m_initialvelocity">\</a>  CCustomTransition::m_initialVelocity  
 Stores the initial velocity.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ccustomtransition__m_pinterpolator">\</a>  CCustomTransition::m_pInterpolator  
 Stores a pointer to a custom interpolator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="ccustomtransition__setinitialvalue">\</a>  CCustomTransition::SetInitialValue  
 Sets an initial value, which will be applied to an animation variable associated with this transition.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
##  \<a name="ccustomtransition__setinitialvelocity">\</a>  CCustomTransition::SetInitialVelocity  
 Sets an initial velocity, which will be applied to an animation variable associated with this transition.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)