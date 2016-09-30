---
title: "CD2DTextLayout Class"
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
  - "CD2DTextLayout"
  - "afxrendertarget/CD2DTextLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DTextLayout class"
ms.assetid: 724bd13c-f2ef-4e55-a775-8cb04b7b7908
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DTextLayout Class
A wrapper for IDWriteTextLayout.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextLayout::CD2DTextLayout](#cd2dtextlayout__cd2dtextlayout)|Constructs a CD2DTextLayout object.|  
|[CD2DTextLayout::~CD2DTextLayout](#cd2dtextlayout__~cd2dtextlayout)|The destructor. Called when a D2D text layout object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextLayout::Create](#cd2dtextlayout__create)|Creates a CD2DTextLayout. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DTextLayout::Destroy](#cd2dtextlayout__destroy)|Destroys a CD2DTextLayout object. (Overrides [CD2DResource::Destroy](../vs140/cd2dresource-class.md#cd2dresource__destroy).)|  
|[CD2DTextLayout::Get](#cd2dtextlayout__get)|Returns IDWriteTextLayout interface|  
|[CD2DTextLayout::GetFontFamilyName](#cd2dtextlayout__getfontfamilyname)|Copies the font family name of the text at the specified position.|  
|[CD2DTextLayout::GetLocaleName](#cd2dtextlayout__getlocalename)|Gets the locale name of the text at the specified position.|  
|[CD2DTextLayout::IsValid](#cd2dtextlayout__isvalid)|Checks resource validity (Overrides [CD2DResource::IsValid](../vs140/cd2dresource-class.md#cd2dresource__isvalid).)|  
|[CD2DTextLayout::ReCreate](#cd2dtextlayout__recreate)|Re-creates a CD2DTextLayout. (Overrides [CD2DResource::ReCreate](../vs140/cd2dresource-class.md#cd2dresource__recreate).)|  
|[CD2DTextLayout::SetFontFamilyName](#cd2dtextlayout__setfontfamilyname)|Sets null-terminated font family name for text within a specified text range|  
|[CD2DTextLayout::SetLocaleName](#cd2dtextlayout__setlocalename)|Sets the locale name for text within a specified text range|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextLayout::operator IDWriteTextLayout*](#cd2dtextlayout__operator_idwritetextlayout_star)|Returns IDWriteTextLayout interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DTextLayout::m_pTextLayout](#cd2dtextlayout__m_ptextlayout)|A pointer to an IDWriteTextLayout.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DTextLayout](../vs140/cd2dtextlayout-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dtextlayout___dtorcd2dtextlayout">\</a>  CD2DTextLayout::~CD2DTextLayout  
 The destructor. Called when a D2D text layout object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dtextlayout__cd2dtextlayout">\</a>  CD2DTextLayout::CD2DTextLayout  
 Constructs a CD2DTextLayout object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A CString object that contains the string to create a new CD2DTextLayout object from.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A CString object that contains the format to apply to the string.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The size of the layout box.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  \<a name="cd2dtextlayout__create">\</a>  CD2DTextLayout::Create  
 Creates a CD2DTextLayout.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dtextlayout__destroy">\</a>  CD2DTextLayout::Destroy  
 Destroys a CD2DTextLayout object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cd2dtextlayout__get">\</a>  CD2DTextLayout::Get  
 Returns IDWriteTextLayout interface  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an IDWriteTextLayout interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dtextlayout__getfontfamilyname">\</a>  CD2DTextLayout::GetFontFamilyName  
 Copies the font family name of the text at the specified position.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The position of the text to examine.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The range of text that has the same formatting as the text at the position specified by currentPosition. This means the run has the exact formatting as the position specified, including but not limited to the font family name.  
  
### Return Value  
 CString object that contains the current font family name.  
  
##  \<a name="cd2dtextlayout__getlocalename">\</a>  CD2DTextLayout::GetLocaleName  
 Gets the locale name of the text at the specified position.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The position of the text to inspect.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The range of text that has the same formatting as the text at the position specified by currentPosition. This means the run has the exact formatting as the position specified, including but not limited to the locale name.  
  
### Return Value  
 CString object that contains the current locale name.  
  
##  \<a name="cd2dtextlayout__isvalid">\</a>  CD2DTextLayout::IsValid  
 Checks resource validity  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if resource is valid; otherwise FALSE.  
  
##  \<a name="cd2dtextlayout__m_ptextlayout">\</a>  CD2DTextLayout::m_pTextLayout  
 A pointer to an IDWriteTextLayout.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cd2dtextlayout__operator_idwritetextlayout_star">\</a>  CD2DTextLayout::operator IDWriteTextLayout*  
 Returns IDWriteTextLayout interface  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an IDWriteTextLayout interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dtextlayout__recreate">\</a>  CD2DTextLayout::ReCreate  
 Re-creates a CD2DTextLayout.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dtextlayout__setfontfamilyname">\</a>  CD2DTextLayout::SetFontFamilyName  
 Sets null-terminated font family name for text within a specified text range  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The font family name that applies to the entire text string within the range specified by textRange  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Text range to which this change applies  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE  
  
##  \<a name="cd2dtextlayout__setlocalename">\</a>  CD2DTextLayout::SetLocaleName  
 Sets the locale name for text within a specified text range  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A null-terminated locale name string  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Text range to which this change applies  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)