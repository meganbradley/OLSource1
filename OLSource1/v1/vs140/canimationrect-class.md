---
title: "CAnimationRect Class"
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
  - "CAnimationRect"
  - "afxanimationcontroller/CAnimationRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationRect class"
ms.assetid: 0294156d-241e-4a57-92b2-31234fe557d6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationRect Class
Implements the functionality of a rectangle whose sides can be animated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationRect::CAnimationRect](#canimationrect__canimationrect)|Overloaded. Constructs an animation rect object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationRect::AddTransition](#canimationrect__addtransition)|Adds transitions for left, top, right and bottom coordinates.|  
|[CAnimationRect::GetBottom](#canimationrect__getbottom)|Provides access to CAnimationVariable representing bottom coordinate.|  
|[CAnimationRect::GetDefaultValue](#canimationrect__getdefaultvalue)|Returns the default values for rectangle's bounds.|  
|[CAnimationRect::GetLeft](#canimationrect__getleft)|Provides access to CAnimationVariable representing left coordinate.|  
|[CAnimationRect::GetRight](#canimationrect__getright)|Provides access to CAnimationVariable representing right coordinate.|  
|[CAnimationRect::GetTop](#canimationrect__gettop)|Provides access to CAnimationVariable representing top coordinate.|  
|[CAnimationRect::GetValue](#canimationrect__getvalue)|Returns current value.|  
|[CAnimationRect::SetDefaultValue](#canimationrect__setdefaultvalue)|Sets default value.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationRect::GetAnimationVariableList](#canimationrect__getanimationvariablelist)|Puts the encapsulated animation variables into a list. (Overrides [CAnimationBaseObject::GetAnimationVariableList](../vs140/canimationbaseobject-class.md#canimationbaseobject__getanimationvariablelist).)|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationRect::operator RECT](#canimationrect__operator_rect)|Converts a CAnimationRect to RECT.|  
|[CAnimationRect::operator=](#canimationrect__operator_eq)|Assigns rect to CAnimationRect.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationRect::m_bFixedSize](#canimationrect__m_bfixedsize)|Specifies whether the rectangle has fixed size.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationRect::m_bottomValue](#canimationrect__m_bottomvalue)|The encapsulated animation variable that represents Bottom bound of animation rectangle.|  
|[CAnimationRect::m_leftValue](#canimationrect__m_leftvalue)|The encapsulated animation variable that represents Left bound of animation rectangle.|  
|[CAnimationRect::m_rightValue](#canimationrect__m_rightvalue)|The encapsulated animation variable that represents Right bound of animation rectangle.|  
|[CAnimationRect::m_szInitial](#canimationrect__m_szinitial)|Specifies initial size of animation rectangle.|  
|[CAnimationRect::m_topValue](#canimationrect__m_topvalue)|The encapsulated animation variable that represents Top bound of animation rectangle.|  
  
## Remarks  
 The CAnimationRect class encapsulates four CAnimationVariable objects and can represent in applications a rectangle. To use this class in application, just instantiate an object of this class, add it to animation controller using CAnimationController::AddAnimationObject and call AddTransition for each transition to be applied to left, right top and bottom coordinates.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CAnimationBaseObject](../vs140/canimationbaseobject-class.md)  
  
 [CAnimationRect](../vs140/canimationrect-class.md)  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="canimationrect__addtransition">\</a>  CAnimationRect::AddTransition  
 Adds transitions for left, top, right and bottom coordinates.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies transition for the left side.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies transition for the top side.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies transition for the right side.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies transition for the bottom side.  
  
### Remarks  
 Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for each rectangle sides. When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied (added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup. If you don't need to apply a transition to one of the rectangle sides, you can pass NULL.  
  
##  \<a name="canimationrect__canimationrect">\</a>  CAnimationRect::CAnimationRect  
 Constructs a CAnimationRect object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Specifies default rectangle.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies Group ID.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies Object ID.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies user-defined data.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Coordinate of top-left corner.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Size of rectangle.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies coordinate of left bound.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies coordinate of top bound.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Specifies coordinate of right bound.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies coordinate of bottom bound.  
  
### Remarks  
 The object is constructed with default values for left, top, right and bottom, Object ID and Group ID, which will be set to 0. They can be changed later at runtime using SetDefaultValue and SetID.  
  
##  \<a name="canimationrect__getanimationvariablelist">\</a>  CAnimationRect::GetAnimationVariableList  
 Puts the encapsulated animation variables into a list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 When the function returns, it contains pointers to four CAnimationVariable objects representing coordinates of rectangle.  
  
##  \<a name="canimationrect__getbottom">\</a>  CAnimationRect::GetBottom  
 Provides access to CAnimationVariable representing bottom coordinate.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A reference to encapsulated CAnimationVariable representing bottom coordinate.  
  
### Remarks  
 You can call this method to get direct access to underlying CAnimationVariable representing the bottom coordinate.  
  
##  \<a name="canimationrect__getdefaultvalue">\</a>  CAnimationRect::GetDefaultValue  
 Returns the default values for rectangle's bounds.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A CRect value containing defaults for left, right, top and bottom.  
  
### Remarks  
 Call this function to retrieve default value, which was previously set by constructor or SetDefaultValue.  
  
##  \<a name="canimationrect__getleft">\</a>  CAnimationRect::GetLeft  
 Provides access to CAnimationVariable representing left coordinate.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A reference to encapsulated CAnimationVariable representing left coordinate.  
  
### Remarks  
 You can call this method to get direct access to underlying CAnimationVariable representing the left coordinate.  
  
##  \<a name="canimationrect__getright">\</a>  CAnimationRect::GetRight  
 Provides access to CAnimationVariable representing right coordinate.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A reference to encapsulated CAnimationVariable representing right coordinate.  
  
### Remarks  
 You can call this method to get direct access to underlying CAnimationVariable representing the right coordinate.  
  
##  \<a name="canimationrect__gettop">\</a>  CAnimationRect::GetTop  
 Provides access to CAnimationVariable representing top coordinate.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A reference to encapsulated CAnimationVariable representing top coordinate.  
  
### Remarks  
 You can call this method to get direct access to underlying CAnimationVariable representing the top coordinate.  
  
##  \<a name="canimationrect__getvalue">\</a>  CAnimationRect::GetValue  
 Returns current value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Output. Contains the current value when this method returns.  
  
### Return Value  
 TRUE, if the current value was successfully retrieved; otherwise FALSE.  
  
### Remarks  
 Call this function to retrieve the current value of animation rectangle. If this method fails or underlying COM objects for left, top, right and bottom have not been initialized, rect contains default value, which was previously set in constructor or by SetDefaultValue.  
  
##  \<a name="canimationrect__m_bfixedsize">\</a>  CAnimationRect::m_bFixedSize  
 Specifies whether the rectangle has fixed size.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 If this member is true, then the size of rectangle is fixed and right and bottom values are recalculated each time the top-left corner is moved according to the fixed size. Set this value to TRUE to easily move the rectangle around the screen. In this case transitions applied to right and bottom coordinates are ignored. The size is stored internally when you construct the object and/or call SetDefaultValue. By default this member is set to FALSE.  
  
##  \<a name="canimationrect__m_bottomvalue">\</a>  CAnimationRect::m_bottomValue  
 The encapsulated animation variable that represents Bottom bound of animation rectangle.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="canimationrect__m_leftvalue">\</a>  CAnimationRect::m_leftValue  
 The encapsulated animation variable that represents Left bound of animation rectangle.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="canimationrect__m_rightvalue">\</a>  CAnimationRect::m_rightValue  
 The encapsulated animation variable that represents Right bound of animation rectangle.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="canimationrect__m_szinitial">\</a>  CAnimationRect::m_szInitial  
 Specifies initial size of animation rectangle.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="canimationrect__m_topvalue">\</a>  CAnimationRect::m_topValue  
 The encapsulated animation variable that represents Top bound of animation rectangle.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="canimationrect__operator_rect">\</a>  CAnimationRect::operator RECT  
 Converts a CAnimationRect to RECT.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Current value of animation rectangle as RECT.  
  
### Remarks  
 This function internally calls GetValue. If GetValue for some reason fails, the returned RECT will contain default values for all rectangle coordinates.  
  
##  \<a name="canimationrect__operator_eq">\</a>  CAnimationRect::operator=  
 Assigns rect to CAnimationRect.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The new value of animation rectangle.  
  
### Remarks  
 It's recommended to do that before animation start, because this operator calls SetDefaultValue, which recreates the underlying COM objects for color components if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
##  \<a name="canimationrect__setdefaultvalue">\</a>  CAnimationRect::SetDefaultValue  
 Sets default value.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies new default values for left, top, right and bottom.  
  
### Remarks  
 Use this function to set a default value to animation object. This methods assigns default values to rectangle's bounds. It also recreates underlying COM objects if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)