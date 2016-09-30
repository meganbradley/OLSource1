---
title: "CInterpolatorBase Class"
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
  - "afxanimationcontroller/CInterpolatorBase"
  - "CInterpolatorBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInterpolatorBase class"
ms.assetid: bbc3dce7-8398-47f9-b97e-e4fd2d737232
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterpolatorBase Class
Implements a callback, which is called by the Animation API when it has to calculate a new value of an animation variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInterpolatorBase::CInterpolatorBase](#cinterpolatorbase__cinterpolatorbase)|Constructs the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CInterpolatorBase::CreateInstance](#cinterpolatorbase__createinstance)|Creates an instance of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and stores a pointer to custom interpolator, which will be handling events.|  
|[CInterpolatorBase::GetDependencies](#cinterpolatorbase__getdependencies)|Gets the interpolator's dependencies. (Overrides <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.)|  
|[CInterpolatorBase::GetDuration](#cinterpolatorbase__getduration)|Gets the interpolator's duration. (Overrides <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.)|  
|[CInterpolatorBase::GetFinalValue](#cinterpolatorbase__getfinalvalue)|Gets the final value to which the interpolator leads. (Overrides <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.)|  
|[CInterpolatorBase::InterpolateValue](#cinterpolatorbase__interpolatevalue)|Interpolates the value at a given offset (Overrides <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.)|  
|[CInterpolatorBase::InterpolateVelocity](#cinterpolatorbase__interpolatevelocity)|Interpolates the velocity at a given offset (Overrides <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.)|  
|[CInterpolatorBase::SetCustomInterpolator](#cinterpolatorbase__setcustominterpolator)|Stores a pointer to custom interpolator, which will be handling events.|  
|[CInterpolatorBase::SetDuration](#cinterpolatorbase__setduration)|Sets the interpolator's duration (Overrides <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.)|  
|[CInterpolatorBase::SetInitialValueAndVelocity](#cinterpolatorbase__setinitialvalueandvelocity)|Sets the interpolator's initial value and velocity. (Overrides <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.)|  
  
## Remarks  
 This handler is created and passed to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> when a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object is being created as a part of animation initialization process (started by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>). Usually you don't need to use this class directly, it just routs all events to a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>-derived class, whose pointer is passed to constructor of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="cinterpolatorbase__cinterpolatorbase">\</a>  CInterpolatorBase::CInterpolatorBase  
 Constructs the CInterpolatorBase object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cinterpolatorbase__createinstance">\</a>  CInterpolatorBase::CreateInstance  
 Creates an instance of CInterpolatorBase and stores a pointer to custom interpolator, which will be handling events.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A pointer to custom interpolator.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Output. Contains a pointer to instance of CInterpolatorBase when the function returns.  
  
### Return Value  
  
##  \<a name="cinterpolatorbase__getdependencies">\</a>  CInterpolatorBase::GetDependencies  
 Gets the interpolator's dependencies.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Output. Aspects of the interpolator that depend on the duration passed to SetDuration.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the GetDependencies method.  
  
##  \<a name="cinterpolatorbase__getduration">\</a>  CInterpolatorBase::GetDuration  
 Gets the interpolator's duration.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Output. The duration of the transition, in seconds.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the GetDuration method.  
  
##  \<a name="cinterpolatorbase__getfinalvalue">\</a>  CInterpolatorBase::GetFinalValue  
 Gets the final value to which the interpolator leads.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Output. The final value of a variable at the end of the transition.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the GetFinalValue method.  
  
##  \<a name="cinterpolatorbase__interpolatevalue">\</a>  CInterpolatorBase::InterpolateValue  
 Interpolates the value at a given offset  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The offset from the start of the transition. The offset is always greater than or equal to zero and less than the duration of the transition. This method is not called if the duration of the transition is zero.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Output. The interpolated value.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the InterpolateValue method.  
  
##  \<a name="cinterpolatorbase__interpolatevelocity">\</a>  CInterpolatorBase::InterpolateVelocity  
 Interpolates the velocity at a given offset  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The offset from the start of the transition. The offset is always greater than or equal to zero and less than or equal to the duration of the transition. This method is not called if the duration of the transition is zero.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Output. The velocity of the variable at the offset.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the InterpolateVelocity method.  
  
##  \<a name="cinterpolatorbase__setcustominterpolator">\</a>  CInterpolatorBase::SetCustomInterpolator  
 Stores a pointer to custom interpolator, which will be handling events.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to custom interpolator.  
  
##  \<a name="cinterpolatorbase__setduration">\</a>  CInterpolatorBase::SetDuration  
 Sets the interpolator's duration  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The duration of the transition.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the SetDuration method.  
  
##  \<a name="cinterpolatorbase__setinitialvalueandvelocity">\</a>  CInterpolatorBase::SetInitialValueAndVelocity  
 Sets the interpolator's initial value and velocity.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The value of the variable at the start of the transition.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The velocity of the variable at the start of the transition.  
  
### Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the SetInitialValueAndVelocity method.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)