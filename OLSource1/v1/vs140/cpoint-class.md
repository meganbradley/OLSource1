---
title: "CPoint Class"
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
  - "CPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LPPOINT structure"
  - "POINT structure"
  - "CPoint class"
ms.assetid: a6d4db93-35cc-444d-9221-c3e160f6edaa
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPoint Class
Similar to the Windows             <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPoint::CPoint](#cpoint__cpoint)|Constructs a                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPoint::Offset](#cpoint__offset)|Adds values to the                                         **x** and                                         **y** members of the                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CPoint::operator -](#cpoint__operator_-)|Returns the difference of a                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and a size, or the negation of a point, or the size difference between two points, or the offset by a negative size.|  
|[CPoint::operator !=](#cpoint__operator__neq)|Checks for inequality between two points.|  
|[CPoint::operator +](#cpoint__operator__add)|Returns the sum of a                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and a size or point, or a                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> offset by a size.|  
|[CPoint::operator +=](#cpoint__operator__add_eq)|Offsets                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> by adding a size or point.|  
|[CPoint::operator -=](428fb5e0ce0f)|Offsets                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> by subtracting a size or point.|  
|[CPoint::operator ==](#cpoint__operator__eq_eq)|Checks for equality between two points.|  
  
## Remarks  
 It also includes member functions to manipulate                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and                 [POINT](../vs140/point-structure.md) structures.  
  
 A                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object can be used wherever a                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> structure is used. The operators of this class that interact with a "size" accept either                 [CSize](../vs140/csize-class.md) objects or                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structures, since the two are interchangeable.  
  
> [!NOTE]
>  This class is derived from the                     <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structure. (The name                     <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a less commonly used name for the                     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure.) This means that the data members of the                     <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure,                     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and                     <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, are accessible data members of                     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  For more information on shared utility classes (like                     <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>), see                     [Shared Classes](../vs140/atl-mfc-shared-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atltypes.h  
  
##  \<a name="cpoint__cpoint">\</a>  CPoint::CPoint  
 Constructs a                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the value of the                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> member of                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Specifies the value of the                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> member of                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 [POINT](../vs140/point-structure.md) structure or                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> that specifies the values used to initialize                                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) that specifies the values used to initialize                                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Sets the                                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> member to the low-order word of                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and the                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> member to the high-order word of                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Remarks  
 If no arguments are given,                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> members are set to 0.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cpoint__offset">\</a>  CPoint::Offset  
 Adds values to the                 **x** and                 **y** members of the                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *xOffset*  
 Specifies the amount to offset the                                 **x** member of the                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 *yOffset*  
 Specifies the amount to offset the                                 **y** member of the                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the amount (                                [POINT](../vs140/point-structure.md) or                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>) to offset the                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies the amount (                                [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) or                                 [CSize](../vs140/csize-class.md)) to offset the                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#28](../vs140/codesnippet/CPP/cpoint-class_1.cpp)]  
  
##  \<a name="cpoint__operator__eq_eq">\</a>  CPoint::operator ==  
 Checks for equality between two points.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Nonzero if the points are equal; otherwise 0.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#29](../vs140/codesnippet/CPP/cpoint-class_2.cpp)]  
  
##  \<a name="cpoint__operator__neq">\</a>  CPoint::operator !=  
 Checks for inequality between two points.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Nonzero if the points are not equal; otherwise 0.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#30](../vs140/codesnippet/CPP/cpoint-class_3.cpp)]  
  
##  \<a name="cpoint__operator__add_eq">\</a>  CPoint::operator +=  
 The first overload adds a size to the                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Contains a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object.  
  
### Remarks  
 The second overload adds a point to the                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 In both cases, addition is done by adding the                         **x** (or                         **cx**) member of the right-hand operand to the                         **x** member of the                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> and adding the                         **y** (or                         **cy**) member of the right-hand operand to the                         **y** member of the                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
 For example, adding                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to a variable which contains                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> changes the variable to                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#31](../vs140/codesnippet/CPP/cpoint-class_4.cpp)]  
  
##  \<a name="cpoint__operator_-_eq">\</a>  CPoint::operator -=  
 The first overload subtracts a size from the                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Contains a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object.  
  
### Remarks  
 The second overload subtracts a point from the                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 In both cases, subtraction is done by subtracting the                         **x** (or                         **cx**) member of the right-hand operand from the                         **x** member of the                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and subtracting the                         **y** (or                         **cy**) member of the right-hand operand from the                         **y** member of the                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
 For example, subtracting                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> from a variable which contains                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> changes the variable to                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#32](../vs140/codesnippet/CPP/cpoint-class_5.cpp)]  
  
##  \<a name="cpoint__operator__add">\</a>  CPoint::operator +  
 Use this operator to offset                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> by a                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object, or to offset a                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> by a                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Contains a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Contains a pointer to a                                 [RECT](../vs140/rect-structure.md) structure or                                 [CRect](../vs140/crect-class.md) object.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> that is offset by a size, a                         **CPoint** that is offset by a point, or a                         **CRect** offset by a point.  
  
### Remarks  
 For example, using one of the first two overloads to offset the point                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> by a point                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> or size                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> returns the value                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
 Adding a rectangle to a point returns the rectangle after being offset by the                         **x** and                         **y** values specified in the point. For example, using the last overload to offset a rectangle                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> by a point                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> returns                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#33](../vs140/codesnippet/CPP/cpoint-class_6.cpp)]  
  
##  \<a name="cpoint__operator_-">\</a>  CPoint::operator -  
 Use one of the first two overloads to subtract a                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object from                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to a                                 [RECT](../vs140/rect-structure.md) structure or a                                 [CRect](../vs140/crect-class.md) object.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> that is the difference between two points, a                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> that is offset by the negation of a size, a                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> that is offset by the negation of a point, or a                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> that is the negation of a point.  
  
### Remarks  
 The third overload offsets a                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> by the negation of                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>. Finally, use the unary operator to negate                         <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
 For example, using the first overload to find the difference between two points                         <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> returns                         <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
 Subtracting a                         <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> from                         <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> does the same calculation as above but returns a                         <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object, not a                         <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object. For example, using the second overload to find the difference between the point                         <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> and the size                         <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> returns                         <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
 Subtracting a rectangle from a point returns the rectangle offset by the negatives of the                         **x** and                         **y** values specified in the point. For example, using the last overload to offset the rectangle                         <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> by the point                         <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> returns                         <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 Use the unary operator to negate a point. For example, using the unary operator with the point                         <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> returns                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#34](../vs140/codesnippet/CPP/cpoint-class_7.cpp)]  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CRect](../vs140/crect-class.md)   
 [CSize](../vs140/csize-class.md)