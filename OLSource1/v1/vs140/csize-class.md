---
title: "CSize Class"
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
  - "CSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SIZE"
  - "dimensions, MFC"
  - "dimensions"
  - "CSize class"
ms.assetid: fb2cf85a-0bc1-46f8-892b-309c108b52ae
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSize Class
Similar to the Windows             [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure, which implements a relative coordinate or position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSize::CSize](#csize__csize)|Constructs a                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSize::operator -](#csize__operator_-)|Subtracts two sizes.|  
|[CSize::operator !=](#csize__operator__neq)|Checks for inequality between                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and a size.|  
|[CSize::operator +](#csize__operator__add)|Adds two sizes.|  
|[CSize::operator +=](#csize__operator__add_eq)|Adds a size to                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[CSize::operator -=](#csize__operator_-_eq)|Subtracts a size from                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[CSize::operator ==](#csize__operator__eq_eq)|Checks for equality between                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and a size.|  
  
## Remarks  
 This class is derived from the                 **SIZE** structure. This means you can pass a                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in a parameter that calls for a                 **SIZE** and that the data members of the                 **SIZE** structure are accessible data members of                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The                 **cx** and                 **cy** members of                 **SIZE** (and                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) are public. In addition,                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> implements member functions to manipulate the                 **SIZE** structure.  
  
> [!NOTE]
>  For more information on shared utility classes (like                     <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>), see                     [Shared Classes](../vs140/atl-mfc-shared-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atltypes.h  
  
##  \<a name="csize__csize">\</a>  CSize::CSize  
 Constructs a                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *initCX*  
 Sets the                                 **cx** member for the                                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 *initCY*  
 Sets the                                 **cy** member for the                                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object used to initialize                                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [POINT](../vs140/point-structure.md) structure or                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object used to initialize                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> used to initialize                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The low-order word is the                                 **cx** member and the high-order word is the                                 **cy** member.  
  
### Remarks  
 If no arguments are given,                         **cx** and                         **cy** are initialized to zero.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#97](../vs140/codesnippet/CPP/csize-class_1.cpp)]  
  
##  \<a name="csize__operator__eq_eq">\</a>  CSize::operator ==  
 Checks for equality between two sizes.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Returns nonzero if the sizes are equal, otherwize 0.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#98](../vs140/codesnippet/CPP/csize-class_2.cpp)]  
  
##  \<a name="csize__operator__neq">\</a>  CSize::operator !=  
 Checks for inequality between two sizes.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Returns nonzero if the sizes are not equal, otherwise 0.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#99](../vs140/codesnippet/CPP/csize-class_3.cpp)]  
  
##  \<a name="csize__operator__add_eq">\</a>  CSize::operator +=  
 Adds a size to this                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_ATLMFC_Utilities#100](../vs140/codesnippet/CPP/csize-class_4.cpp)]  
  
##  \<a name="csize__operator_-_eq">\</a>  CSize::operator -=  
 Subtracts a size from this                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_ATLMFC_Utilities#101](../vs140/codesnippet/CPP/csize-class_5.cpp)]  
  
##  \<a name="csize__operator__add">\</a>  CSize::operator +  
 These operators add this                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> value to the value of parameter.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 See the following descriptions of the individual operators:  
  
-   **operator +(**  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  **)** This operation adds two                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> values.  
  
-   **operator +(**  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  **)** This operation offsets (moves) a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) (or                                 [CPoint](../vs140/cpoint-class.md)) value by this                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> value. The                                 **cx** and                                 **cy** members of this                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value are added to the                                 **x** and                                 **y** data members of the                                 **POINT** value. It is analogous to the version of                                 [CPoint::operator +](../vs140/cpoint-class.md#cpoint__operator__add) that takes a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) parameter.  
  
-   **operator +(**  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  **)** This operation offsets (moves) a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) (or                                 [CRect](../vs140/crect-class.md)) value by this                                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> value. The                                 **cx** and                                 **cy** members of this                                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> value are added to the                                 **left**,                                 **top**,                                 **right**, and                                 **bottom** data members of the                                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> value. It is analogous to the version of                                 [CRect::operator +](../vs140/crect-class.md#crect__operator__add) that takes a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) parameter.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#102](../vs140/codesnippet/CPP/csize-class_6.cpp)]  
  
##  \<a name="csize__operator_-">\</a>  CSize::operator -  
 The first three of these operators subtract this                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value to the value of parameter.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The fourth operator, the unary minus, changes the sign of the                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> value. See the following descriptions of the individual operators:  
  
-   **operator -(**  <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  **)** This operation subtracts two                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> values.  
  
-   **operator -(**  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  **)** This operation offsets (moves) a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) or                                 [CPoint](../vs140/cpoint-class.md) value by the additive inverse of this                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> value. The                                 **cx** and                                 **cy** of this                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value are subtracted from the                                 **x** and                                 **y** data members of the                                 **POINT** value. It is analogous to the version of                                 [CPoint::operator -](../vs140/cpoint-class.md#cpoint__operator_-) that takes a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) parameter.  
  
-   **operator -(**  <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  **)** This operation offsets (moves) a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) or                                 [CRect](../vs140/crect-class.md) value by the additive inverse of this                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> value. The                                 **cx** and                                 **cy** members of this                                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value are subtracted from the                                 **left**,                                 **top**,                                 **right**, and                                 **bottom** data members of the                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> value. It is analogous to the version of                                 [CRect::operator -](../vs140/crect-class.md#crect__operator_-) that takes a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) parameter.  
  
-   **operator -( )** This operation returns the additive inverse of this                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> value.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#103](../vs140/codesnippet/CPP/csize-class_7.cpp)]  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect](../vs140/crect-class.md)   
 [CPoint](../vs140/cpoint-class.md)