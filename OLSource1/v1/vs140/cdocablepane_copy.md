---
title: "CDocablePane_copy"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 35c344ba-4003-4d23-987e-0e7503bd90f5
caps.latest.revision: 8
---
# CDocablePane_copy
Similar to a Windows             [RECT](../vs140/rect-structure.md) structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRect::CRect](#crect__crect)|Constructs a                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRect::BottomRight](#crect__bottomright)|Returns the bottom-right point of                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
|[CRect::CenterPoint](#crect__centerpoint)|Returns the centerpoint of                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.|  
|[CRect::CopyRect](#crect__copyrect)|Copies the dimensions of a source rectangle to                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.|  
|[CRect::DeflateRect](#crect__deflaterect)|Decreases the width and height of                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
|[CRect::EqualRect](#crect__equalrect)|Determines whether                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is equal to the given rectangle.|  
|[CRect::Height](#crect__height)|Calculates the height of                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|[CRect::InflateRect](#crect__inflaterect)|Increases the width and height of                                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.|  
|[CRect::IntersectRect](#crect__intersectrect)|Sets                                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> equal to the intersection of two rectangles.|  
|[CRect::IsRectEmpty](#crect__isrectempty)|Determines whether                                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is empty.                                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is empty if the width and/or height are 0.|  
|[CRect::IsRectNull](#crect__isrectnull)|Determines whether the                                         **top**,                                         **bottom**,                                         **left**, and                                         **right** member variables are all equal to 0.|  
|[CRect::MoveToX](#crect__movetox)|Moves                                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to the specified x-coordinate.|  
|[CRect::MoveToXY](#crect__movetoxy)|Moves                                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to the specified x- and y-coordinates.|  
|[CRect::MoveToY](#crect__movetoy)|Moves                                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to the specified y-coordinate.|  
|[CRect::NormalizeRect](#crect__normalizerect)|Standardizes the height and width of                                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.|  
|[CRect::OffsetRect](#crect__offsetrect)|Moves                                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> by the specified offsets.|  
|[CRect::PtInRect](#crect__ptinrect)|Determines whether the specified point lies within                                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.|  
|[CRect::SetRect](#crect__setrect)|Sets the dimensions of                                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.|  
|[CRect::SetRectEmpty](#crect__setrectempty)|Sets                                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to an empty rectangle (all coordinates equal to 0).|  
|[CRect::Size](#crect__size)|Calculates the size of                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.|  
|[CRect::SubtractRect](#crect__subtractrect)|Subtracts one rectangle from another.|  
|[CRect::TopLeft](#crect__topleft)|Returns the top-left point of                                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.|  
|[CRect::UnionRect](#crect__unionrect)|Sets                                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> equal to the union of two rectangles.|  
|[CRect::Width](#crect__width)|Calculates the width of                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CRect::operator -](#crect__operator_-)|Subtracts the given offsets from                                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or deflates                                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and returns the resulting                                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.|  
|[CRect::operator LPCRECT](#crect__operator_lpcrect)|Converts a                                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to an                                         **LPCRECT**.|  
|[CRect::operator LPRECT](#crect__operator_lprect)|Converts a                                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to an                                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.|  
|[CRect::operator !=](#crect__operator__neq)|Determines whether                                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is not equal to a rectangle.|  
|[CRect::operator &](#crect__operator__amp_)|Creates the intersection of                                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and a rectangle and returns the resulting                                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.|  
|[CRect::operator &=](#crect__operator__amp__eq)|Sets                                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> equal to the intersection of                                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and a rectangle.|  
|[CRect::operator &#124;](#crect__operator__or)|Creates the union of                                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and a rectangle and returns the resulting                                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.|  
|[CRect::operator &#124;=](#crect__operator__or_eq)|Sets                                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> equal to the union of                                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and a rectangle.|  
|[CRect::operator +](#crect__operator__add)|Adds the given offsets to                                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or inflates                                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and returns the resulting                                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.|  
|[CRect::operator +=](#crect__operator__add_eq)|Adds the specified offsets to                                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or inflates                                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.|  
|[CRect::operator =](#crect__operator__eq)|Copies the dimensions of a rectangle to                                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.|  
|[CRect::operator -=](#crect__operator_-_eq)|Subtracts the specified offsets from                                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or deflates                                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|  
|[CRect::operator ==](#crect__operator__eq_eq)|Determines whether                                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is equal to a rectangle.|  
  
## Remarks  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> also includes member functions to manipulate                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> objects and Windows                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> structures.  
  
 A                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object can be passed as a function parameter wherever a                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> structure,                 **LPCRECT**, or                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> can be passed.  
  
> [!NOTE]
>  This class is derived from the                     **tagRECT** structure. (The name                     **tagRECT** is a less-commonly-used name for the                     <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> structure.) This means that the data members (                    **left**,                     **top**,                     **right**, and                     **bottom**) of the                     <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> structure are accessible data members of                     <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
 A                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> contains member variables that define the top-left and bottom-right points of a rectangle.  
  
 When specifying a                 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, you must be careful to construct it so that it is normalized — in other words, such that the value of the left coordinate is less than the right and the top is less than the bottom. For example, a top left of (10,10) and bottom right of (20,20) defines a normalized rectangle but a top left of (20,20) and bottom right of (10,10) defines a non-normalized rectangle. If the rectangle is not normalized, many                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> member functions may return incorrect results. (See                 [CRect::NormalizeRect](#crect__normalizerect) for a list of these functions.) Before you call a function that requires normalized rectangles, you can normalize non-normalized rectangles by calling the                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> function.  
  
 Use caution when manipulating a                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> with the                 [CDC::DPtoLP](../vs140/cdc--dptolp.md) and                 [CDC::LPtoDP](../vs140/cdc--lptodp.md) member functions. If the mapping mode of a display context is such that the y-extent is negative, as in                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, then                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> will transform the                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> so that its top is greater than the bottom. Functions such as                 **Height** and                 **Size** will then return negative values for the height of the transformed                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, and the rectangle will be non-normalized.  
  
 When using overloaded                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> operators, the first operand must be a                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>; the second can be either a                 [RECT](../vs140/rect-structure.md) structure or a                 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  For more information on shared utility classes (like                     <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>), see                     [Shared Classes](../vs140/atl-mfc-shared-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atltypes.h  
  
##  \<a name="crect__bottomright">\</a>  CRect::BottomRight  
 The coordinates are returned as a reference to a                 [CPoint](../vs140/cpoint-class.md) object that is contained in                 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The coordinates of the bottom-right corner of the rectangle.  
  
### Remarks  
 You can use this function to either get or set the bottom-right corner of the rectangle. Set the corner by using this function on the left side of the assignment operator.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#35](../vs140/codesnippet/CPP/cdocablepane_copy_1.cpp)]  
  
##  \<a name="crect__centerpoint">\</a>  CRect::CenterPoint  
 Calculates the centerpoint of                 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> by adding the left and right values and dividing by two, and adding the top and bottom values and dividing by two.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A                         <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object that is the centerpoint of                         <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#36](../vs140/codesnippet/CPP/cdocablepane_copy_2.cpp)]  
  
##  \<a name="crect__copyrect">\</a>  CRect::CopyRect  
 Copies the                 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> rectangle into                 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Points to the                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object that is to be copied.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#37](../vs140/codesnippet/CPP/cdocablepane_copy_3.cpp)]  
  
##  \<a name="crect__crect">\</a>  CRect::CRect  
 Constructs a                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *l*  
 Specifies the left position of                                 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
 *t*  
 Specifies the top of                                 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
 *r*  
 Specifies the right position of                                 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
 *b*  
 Specifies the bottom of                                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 *srcRect*  
 Refers to the                                 [RECT](../vs140/rect-structure.md) structure with the coordinates for                                 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Points to the                                 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> structure with the coordinates for                                 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Specifies the origin point for the rectangle to be constructed. Corresponds to the top-left corner.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Specifies the displacement from the top-left corner to the bottom-right corner of the rectangle to be constructed.  
  
 *topLeft*  
 Specifies the top-left position of                                 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
 *bottomRight*  
 Specifies the bottom-right position of                                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
### Remarks  
 If no arguments are given,                         **left**,                         **top**,                         **right**, and                         **bottom** members are not initialized.  
  
 The                         <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>(                         **const RECT&** ) and                         <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>(                         **LPCRECT** ) constructors perform a                         [CopyRect](#crect__copyrect). The other constructors initialize the member variables of the object directly.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#38](../vs140/codesnippet/CPP/cdocablepane_copy_4.cpp)]  
  
##  \<a name="crect__deflaterect">\</a>  CRect::DeflateRect  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> deflates                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> by moving its sides toward its center.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the number of units to deflate the left and right sides of                                 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
 *y*  
 Specifies the number of units to deflate the top and bottom of                                 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) or                                 [CSize](../vs140/csize-class.md) that specifies the number of units to deflate                                 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>. The                                 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> value specifies the number of units to deflate the left and right sides and the                                 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> value specifies the number of units to deflate the top and bottom.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> that specifies the number of units to deflate each side.  
  
 *l*  
 Specifies the number of units to deflate the left side of                                 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
 *t*  
 Specifies the number of units to deflate the top of                                 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
 *r*  
 Specifies the number of units to deflate the right side of                                 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
 *b*  
 Specifies the number of units to deflate the bottom of                                 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
### Remarks  
 To do this,                         <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> adds units to the left and top and subtracts units from the right and bottom. The parameters of                         <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> are signed values; positive values deflate                         <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> and negative values inflate it.  
  
 The first two overloads deflate both pairs of opposite sides of                         <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> so that its total width is decreased by two times                         *x* (or                         <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>) and its total height is decreased by two times                         *y* (or                         <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>). The other two overloads deflate each side of                         <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> independently of the others.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#39](../vs140/codesnippet/CPP/cdocablepane_copy_5.cpp)]  
  
##  \<a name="crect__equalrect">\</a>  CRect::EqualRect  
 Determines whether                 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> is equal to the given rectangle.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> object that contains the upper-left and lower-right corner coordinates of a rectangle.  
  
### Return Value  
 Nonzero if the two rectangles have the same top, left, bottom, and right values; otherwise 0.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#40](../vs140/codesnippet/CPP/cdocablepane_copy_6.cpp)]  
  
##  \<a name="crect__height">\</a>  CRect::Height  
 Calculates the height of                 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> by subtracting the top value from the bottom value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The height of                         <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
### Remarks  
 The resulting value can be negative.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangle before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#41](../vs140/codesnippet/CPP/cdocablepane_copy_7.cpp)]  
  
##  \<a name="crect__inflaterect">\</a>  CRect::InflateRect  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> inflates                 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> by moving its sides away from its center.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the number of units to inflate the left and right sides of                                 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 *y*  
 Specifies the number of units to inflate the top and bottom of                                 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) or                                 [CSize](../vs140/csize-class.md) that specifies the number of units to inflate                                 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>. The                                 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> value specifies the number of units to inflate the left and right sides and the                                 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> value specifies the number of units to inflate the top and bottom.  
  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> that specifies the number of units to inflate each side.  
  
 *l*  
 Specifies the number of units to inflate the left side of                                 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
 *t*  
 Specifies the number of units to inflate the top of                                 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
 *r*  
 Specifies the number of units to inflate the right side of                                 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
 *b*  
 Specifies the number of units to inflate the bottom of                                 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Remarks  
 To do this,                         <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> subtracts units from the left and top and adds units to the right and bottom. The parameters of                         <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> are signed values; positive values inflate                         <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> and negative values deflate it.  
  
 The first two overloads inflate both pairs of opposite sides of                         <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> so that its total width is increased by two times                         *x* (or                         <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>) and its total height is increased by two times                         *y* (or                         <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>). The other two overloads inflate each side of                         <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> independently of the others.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#42](../vs140/codesnippet/CPP/cdocablepane_copy_8.cpp)]  
  
##  \<a name="crect__intersectrect">\</a>  CRect::IntersectRect  
 Makes a                 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> equal to the intersection of two existing rectangles.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> object that contains a source rectangle.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 Points to a                                 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> structure or                                 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object that contains a source rectangle.  
  
### Return Value  
 Nonzero if the intersection is not empty; 0 if the intersection is empty.  
  
### Remarks  
 The intersection is the largest rectangle contained in both existing rectangles.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#43](../vs140/codesnippet/CPP/cdocablepane_copy_9.cpp)]  
  
##  \<a name="crect__isrectempty">\</a>  CRect::IsRectEmpty  
 Determines whether                 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> is empty.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if                         <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> is empty; 0 if                         <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> is not empty.  
  
### Remarks  
 A rectangle is empty if the width and/or height are 0 or negative. Differs from                         <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, which determines whether all coordinates of the rectangle are zero.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangle before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#44](../vs140/codesnippet/CPP/cdocablepane_copy_10.cpp)]  
  
##  \<a name="crect__isrectnull">\</a>  CRect::IsRectNull  
 Determines whether the top, left, bottom, and right values of                 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> are all equal to 0.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if                         <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>'s top, left, bottom, and right values are all equal to 0; otherwise 0.  
  
### Remarks  
 Differs from                         <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>, which determines whether the rectangle is empty.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#45](../vs140/codesnippet/CPP/cdocablepane_copy_11.cpp)]  
  
##  \<a name="crect__movetox">\</a>  CRect::MoveToX  
 Call this function to move the rectangle to the absolute x-coordinate specified by                 *x*.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The absolute x-coordinate for the upper-left corner of the rectangle.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#46](../vs140/codesnippet/CPP/cdocablepane_copy_12.cpp)]  
  
##  \<a name="crect__movetoxy">\</a>  CRect::MoveToXY  
 Call this function to move the rectangle to the absolute x- and y-coordinates specified.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The absolute x-coordinate for the upper-left corner of the rectangle.  
  
 *y*  
 The absolute y-coordinate for the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 A                                 **POINT** structure specifying the absolute upper-left corner of the rectangle.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#47](../vs140/codesnippet/CPP/cdocablepane_copy_13.cpp)]  
  
##  \<a name="crect__movetoy">\</a>  CRect::MoveToY  
 Call this function to move the rectangle to the absolute y-coordinate specified by                 *y*.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *y*  
 The absolute y-coordinate for the upper-left corner of the rectangle.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#48](../vs140/codesnippet/CPP/cdocablepane_copy_14.cpp)]  
  
##  \<a name="crect__normalizerect">\</a>  CRect::NormalizeRect  
 Normalizes                 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> so that both the height and width are positive.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The rectangle is normalized for fourth-quadrant positioning, which Windows typically uses for coordinates.                         <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> compares the top and bottom values, and swaps them if the top is greater than the bottom. Similarly, it swaps the left and right values if the left is greater than the right. This function is useful when dealing with different mapping modes and inverted rectangles.  
  
> [!NOTE]
>  The following                             <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> member functions require normalized rectangles in order to work properly:                             [Height](#crect__height),                             [Width](#crect__width),                             [Size](#crect__size),                             [IsRectEmpty](#crect__isrectempty),                             [PtInRect](#crect__ptinrect),                             [EqualRect](#crect__equalrect),                             [UnionRect](#crect__unionrect),                             [IntersectRect](#crect__intersectrect),                             [SubtractRect](#crect__subtractrect),                             [operator ==](#crect__operator__eq_eq),                             [operator !=](#crect__operator__neq),                             [operator &#124;](#crect__operator__or),                             [operator &#124;=](#crect__operator__or_eq),                             [operator &](#crect__operator__amp_), and                             [operator &=](#crect__operator__amp__eq).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#49](../vs140/codesnippet/CPP/cdocablepane_copy_15.cpp)]  
  
##  \<a name="crect__offsetrect">\</a>  CRect::OffsetRect  
 Moves                 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> by the specified offsets.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the amount to move left or right. It must be negative to move left.  
  
 *y*  
 Specifies the amount to move up or down. It must be negative to move up.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object specifying both dimensions by which to move.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 Contains a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object specifying both dimensions by which to move.  
  
### Remarks  
 Moves                         <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> *x* units along the x-axis and                         *y* units along the y-axis. The                         *x* and                         *y* parameters are signed values, so                         <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> can be moved left or right and up or down.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#50](../vs140/codesnippet/CPP/cdocablepane_copy_16.cpp)]  
  
##  \<a name="crect__operator_lpcrect">\</a>  CRect::operator LPCRECT  
 Converts a                 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> to an                 [LPCRECT](../vs140/data-types--mfc-.md).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 When you use this function, you don't need the address-of (                        **&**) operator. This operator will be automatically used when you pass a                         <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> object to a function that expects an                         **LPCRECT**.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#58](../vs140/codesnippet/CPP/cdocablepane_copy_17.cpp)]  
  
##  \<a name="crect__operator_lprect">\</a>  CRect::operator LPRECT  
 Converts a                 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> to an                 [LPRECT](../vs140/data-types--mfc-.md).  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 When you use this function, you don't need the address-of (                        **&**) operator. This operator will be automatically used when you pass a                         <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object to a function that expects an                         <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.  
  
### Example  
 See the example for                                 [CRect::operator LPCRECT](#crect__operator_lpcrect).  
  
##  \<a name="crect__operator__eq">\</a>  CRect::operator =  
 Assigns                 *srcRect* to                 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *srcRect*  
 Refers to a source rectangle. Can be a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#59](../vs140/codesnippet/CPP/cdocablepane_copy_18.cpp)]  
  
##  \<a name="crect__operator__eq_eq">\</a>  CRect::operator ==  
 Determines whether                 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> is equal to                 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> by comparing the coordinates of their upper-left and lower-right corners.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 Refers to a source rectangle. Can be a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if equal; otherwise 0.  
  
### Remarks  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#60](../vs140/codesnippet/CPP/cdocablepane_copy_19.cpp)]  
  
##  \<a name="crect__operator__neq">\</a>  CRect::operator !=  
 Determines whether                 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is not equal to                 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> by comparing the coordinates of their upper-left and lower-right corners.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 Refers to a source rectangle. Can be a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if not equal; otherwise 0.  
  
### Remarks  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#61](../vs140/codesnippet/CPP/cdocablepane_copy_20.cpp)]  
  
##  \<a name="crect__operator__add_eq">\</a>  CRect::operator +=  
 The first two overloads move                 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> by the specified offsets.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 A                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object that specifies the number of units to move the rectangle.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object that specifies the number of units to move the rectangle.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> object that contains the number of units to inflate each side of                                 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.  
  
### Remarks  
 The parameter's                         *x* and                         *y* (or                         <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>) values are added to                         <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>.  
  
 The third overload inflates                         <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> by the number of units specifed in each member of the parameter.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#62](../vs140/codesnippet/CPP/cdocablepane_copy_21.cpp)]  
  
##  \<a name="crect__operator_-_eq">\</a>  CRect::operator -=  
 The first two overloads move                 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> by the specified offsets.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 A                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object that specifies the number of units to move the rectangle.  
  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object that specifies the number of units to move the rectangle.  
  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> object that contains the number of units to deflate each side of                                 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
### Remarks  
 The parameter's                         *x* and                         *y* (or                         <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>) values are subtracted from                         <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>.  
  
 The third overload deflates                         <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> by the number of units specifed in each member of the parameter. Note that this overload functions like                         [DeflateRect](#crect__deflaterect).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#63](../vs140/codesnippet/CPP/cdocablepane_copy_22.cpp)]  
  
##  \<a name="crect__operator__amp__eq">\</a>  CRect::operator &amp;=  
 Sets                 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> equal to the intersection of                 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 Contains a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>.  
  
### Remarks  
 The intersection is the largest rectangle that is contained in both rectangles.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 See the example for                                 [CRect::IntersectRect](#crect__intersectrect).  
  
##  \<a name="crect__operator__or_eq">\</a>  CRect::operator &#124;=  
 Sets                 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> equal to the union of                 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 Contains a                                 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> or                                 [RECT](../vs140/rect-structure.md).  
  
### Remarks  
 The union is the smallest rectangle that contains both source rectangles.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#64](../vs140/codesnippet/CPP/cdocablepane_copy_23.cpp)]  
  
##  \<a name="crect__operator__add">\</a>  CRect::operator +  
 The first two overloads return a                 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> object that is equal to                 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> displaced by the specified offsets.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 A                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object that specifies the number of units to move the return value.  
  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 [CSize](../vs140/csize-class.md) object that specifies the number of units to move the return value.  
  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> object that contains the number of units to inflate each side of the return value.  
  
### Return Value  
 The                         <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> resulting from moving or inflating                         <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> by the number of units specified in the parameter.  
  
### Remarks  
 The parameter's                         *x* and                         *y* (or                         <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>) parameters are added to                         <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>'s position.  
  
 The third overload returns a new                         <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> that is equal to                         <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> inflated by the number of units specifed in each member of the parameter.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#65](../vs140/codesnippet/CPP/cdocablepane_copy_24.cpp)]  
  
##  \<a name="crect__operator_-">\</a>  CRect::operator -  
 The first two overloads return a                 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> object that is equal to                 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> displaced by the specified offsets.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 A                                 [POINT](../vs140/point-structure.md) structure or                                 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> object that specifies the number of units to move the return value.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 A                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or                                 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> object that specifies the number of units to move the return value.  
  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> object that contains the number of units to deflate each side of the return value.  
  
### Return Value  
 The                         <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> resulting from moving or deflating                         <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> by the number of units specified in the parameter.  
  
### Remarks  
 The parameter's                         *x* and                         *y* (or                         <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>) parameters are subtracted from                         <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>'s position.  
  
 The third overload returns a new                         <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> that is equal to                         <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> deflated by the number of units specifed in each member of the parameter. Note that this overload functions like                         [DeflateRect](#crect__deflaterect), not                         [SubtractRect](#crect__subtractrect).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#66](../vs140/codesnippet/CPP/cdocablepane_copy_25.cpp)]  
  
##  \<a name="crect__operator__amp_">\</a>  CRect::operator &amp;  
 Returns a                 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> that is the intersection of                 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> and                 *rect2*.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *rect2*  
 Contains a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> that is the intersection of                         <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> and                         *rect2*.  
  
### Remarks  
 The intersection is the largest rectangle that is contained in both rectangles.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#67](../vs140/codesnippet/CPP/cdocablepane_copy_26.cpp)]  
  
##  \<a name="crect__operator__or">\</a>  CRect::operator &#124;  
 Returns a                 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> that is the union of                 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> and                 *rect2*.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 *rect2*  
 Contains a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> that is the union of                         <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> and                         *rect2*.  
  
### Remarks  
 The union is the smallest rectangle that contains both rectangles.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#68](../vs140/codesnippet/CPP/cdocablepane_copy_27.cpp)]  
  
##  \<a name="crect__ptinrect">\</a>  CRect::PtInRect  
 Determines whether the specified point lies within                 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 Contains a                                 [POINT](../vs140/point-structure.md) structure or                                 [CPoint](../vs140/cpoint-class.md) object.  
  
### Return Value  
 Nonzero if the point lies within                         <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>; otherwise 0.  
  
### Remarks  
 A point is within                         <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> if it lies on the left or top side or is within all four sides. A point on the right or bottom side is outside                         <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangle before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#51](../vs140/codesnippet/CPP/cdocablepane_copy_28.cpp)]  
  
##  \<a name="crect__setrect">\</a>  CRect::SetRect  
 Sets the dimensions of                 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> to the specified coordinates.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner.  
  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner.  
  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner.  
  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#52](../vs140/codesnippet/CPP/cdocablepane_copy_29.cpp)]  
  
##  \<a name="crect__setrectempty">\</a>  CRect::SetRectEmpty  
 Makes                 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> a null rectangle by setting all coordinates to zero.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_ATLMFC_Utilities#53](../vs140/codesnippet/CPP/cdocablepane_copy_30.cpp)]  
  
##  \<a name="crect__size">\</a>  CRect::Size  
 The                 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> members of the return value contain the height and width of                 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 A                         [CSize](../vs140/csize-class.md) object that contains the size of                         <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>.  
  
### Remarks  
 Either the height or width can be negative.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangle before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#54](../vs140/codesnippet/CPP/cdocablepane_copy_31.cpp)]  
  
##  \<a name="crect__subtractrect">\</a>  CRect::SubtractRect  
 Makes the dimensions of the                 **CRect** equal to the subtraction of                 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> from                 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 Points to the                                 [RECT](../vs140/rect-structure.md) structure or                                 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> object from which a rectangle is to be subtracted.  
  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 Points to the                                 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> structure or                                 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> object that is to be subtracted from the rectangle pointed to by the                                 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The subtraction is the smallest rectangle that contains all of the points in                         <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> that are not in the intersection of                         <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> and                         *lpRectScr2*.  
  
 The rectangle specified by                         <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> will be unchanged if the rectangle specified by                         <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> doesn't completely overlap the rectangle specified by                         *lpRectSrc1* in at least one of the x- or y-directions.  
  
 For example, if                         <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> were (10,10, 100,100) and                         <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> were (50,50, 150,150), the rectangle pointed to by                         <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> would be unchanged when the function returned. If                         <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> were (10,10, 100,100) and                         <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> were (50,10, 150,150), however, the rectangle pointed to by                         <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> would contain the coordinates (10,10, 50,100) when the function returned.  
  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> is not the same as                         [operator -](#crect__operator_-) nor                         [operator -=](#crect__operator_-_eq). Neither of these operators ever calls                         <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#55](../vs140/codesnippet/CPP/cdocablepane_copy_32.cpp)]  
  
##  \<a name="crect__topleft">\</a>  CRect::TopLeft  
 The coordinates are returned as a reference to a                 [CPoint](../vs140/cpoint-class.md) object that is contained in                 <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 The coordinates of the top-left corner of the rectangle.  
  
### Remarks  
 You can use this function to either get or set the top-left corner of the rectangle. Set the corner by using this function on the left side of the assignment operator.  
  
### Example  
 See the example for                                 [CRect::CenterPoint](#crect__centerpoint).  
  
##  \<a name="crect__unionrect">\</a>  CRect::UnionRect  
 Makes the dimensions of                 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> equal to the union of the two source rectangles.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](../vs140/rect-structure.md) or                                 <CodeContentPlaceHolder>322\</CodeContentPlaceHolder> that contains a source rectangle.  
  
 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
 Points to a                                 <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> that contains a source rectangle.  
  
### Return Value  
 Nonzero if the union is not empty; 0 if the union is empty.  
  
### Remarks  
 The union is the smallest rectangle that contains both source rectangles.  
  
 Windows ignores the dimensions of an empty rectangle; that is, a rectangle that has no height or has no width.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangles before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#56](../vs140/codesnippet/CPP/cdocablepane_copy_33.cpp)]  
  
##  \<a name="crect__width">\</a>  CRect::Width  
 Calculates the width of                 <CodeContentPlaceHolder>326\</CodeContentPlaceHolder> by subtracting the left value from the right value.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The width of                         <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>.  
  
### Remarks  
 The width can be negative.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call                             [NormalizeRect](#crect__normalizerect) to normalize the rectangle before calling this function.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#57](../vs140/codesnippet/CPP/cdocablepane_copy_34.cpp)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint](../vs140/cpoint-class.md)   
 [CSize](../vs140/csize-class.md)   
 [RECT](../vs140/rect-structure.md)