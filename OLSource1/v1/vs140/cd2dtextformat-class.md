---
title: "CD2DTextFormat Class"
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
  - "afxrendertarget/CD2DTextFormat"
  - "CD2DTextFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DTextFormat class"
ms.assetid: db194cec-9dae-4644-ab84-7c43b7164117
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DTextFormat Class
A wrapper for IDWriteTextFormat.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextFormat::CD2DTextFormat](#cd2dtextformat__cd2dtextformat)|Constructs a CD2DTextFormat object.|  
|[CD2DTextFormat::~CD2DTextFormat](#cd2dtextformat__~cd2dtextformat)|The destructor. Called when a D2D text format object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextFormat::Create](#cd2dtextformat__create)|Creates a CD2DTextFormat. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DTextFormat::Destroy](#cd2dtextformat__destroy)|Destroys a CD2DTextFormat object. (Overrides [CD2DResource::Destroy](../vs140/cd2dresource-class.md#cd2dresource__destroy).)|  
|[CD2DTextFormat::Get](#cd2dtextformat__get)|Returns IDWriteTextFormat interface|  
|[CD2DTextFormat::GetFontFamilyName](#cd2dtextformat__getfontfamilyname)|Gets a copy of the font family name.|  
|[CD2DTextFormat::GetLocaleName](#cd2dtextformat__getlocalename)|Gets a copy of the locale name.|  
|[CD2DTextFormat::IsValid](#cd2dtextformat__isvalid)|Checks resource validity (Overrides [CD2DResource::IsValid](../vs140/cd2dresource-class.md#cd2dresource__isvalid).)|  
|[CD2DTextFormat::ReCreate](#cd2dtextformat__recreate)|Re-creates a CD2DTextFormat. (Overrides [CD2DResource::ReCreate](../vs140/cd2dresource-class.md#cd2dresource__recreate).)|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextFormat::operator IDWriteTextFormat*](#cd2dtextformat__operator_idwritetextformat_star)|Returns IDWriteTextFormat interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextFormat::m_pTextFormat](#cd2dtextformat__m_ptextformat)|A pointer to an IDWriteTextFormat.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DTextFormat](../vs140/cd2dtextformat-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dtextformat___dtorcd2dtextformat">\</a>  CD2DTextFormat::~CD2DTextFormat  
 The destructor. Called when a D2D text format object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dtextformat__cd2dtextformat">\</a>  CD2DTextFormat::CD2DTextFormat  
 Constructs a CD2DTextFormat object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A CString object that contains the name of the font family.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The logical size of the font in DIP ("device-independent pixel") units. A DIPequals 1/96 inch.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A value that indicates the font weight for the text object.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A value that indicates the font style for the text object.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A value that indicates the font stretch for the text object.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A CString object that contains the locale name.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A pointer to a font collection object. When this is NULL, indicates the system font collection.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  \<a name="cd2dtextformat__create">\</a>  CD2DTextFormat::Create  
 Creates a CD2DTextFormat.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dtextformat__destroy">\</a>  CD2DTextFormat::Destroy  
 Destroys a CD2DTextFormat object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cd2dtextformat__get">\</a>  CD2DTextFormat::Get  
 Returns IDWriteTextFormat interface  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an IDWriteTextFormat interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dtextformat__getfontfamilyname">\</a>  CD2DTextFormat::GetFontFamilyName  
 Gets a copy of the font family name.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 CString object that contains the current font family name.  
  
##  \<a name="cd2dtextformat__getlocalename">\</a>  CD2DTextFormat::GetLocaleName  
 Gets a copy of the locale name.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 CString object that contains the current locale name.  
  
##  \<a name="cd2dtextformat__isvalid">\</a>  CD2DTextFormat::IsValid  
 Checks resource validity  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if resource is valid; otherwise FALSE.  
  
##  \<a name="cd2dtextformat__m_ptextformat">\</a>  CD2DTextFormat::m_pTextFormat  
 A pointer to an IDWriteTextFormat.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cd2dtextformat__operator_idwritetextformat_star">\</a>  CD2DTextFormat::operator IDWriteTextFormat*  
 Returns IDWriteTextFormat interface  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an IDWriteTextFormat interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dtextformat__recreate">\</a>  CD2DTextFormat::ReCreate  
 Re-creates a CD2DTextFormat.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)