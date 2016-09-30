---
title: "CPictureHolder Class"
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
  - "Picture"
  - "CPictureHolder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Picture property"
  - "controls [MFC], OLE"
  - "OLE controls, image"
  - "CPictureHolder class"
ms.assetid: a4f59775-704a-41dd-b5bd-2e531c95127a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPictureHolder Class
Implements a Picture property, which allows the user to display a picture in your control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPictureHolder::CPictureHolder](#cpictureholder__cpictureholder)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPictureHolder::CreateEmpty](#cpictureholder__createempty)|Creates an empty <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[CPictureHolder::CreateFromBitmap](#cpictureholder__createfrombitmap)|Creates a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object from a bitmap.|  
|[CPictureHolder::CreateFromIcon](#cpictureholder__createfromicon)|Creates a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object from an icon.|  
|[CPictureHolder::CreateFromMetafile](#cpictureholder__createfrommetafile)|Creates a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object from a metafile.|  
|[CPictureHolder::GetDisplayString](#cpictureholder__getdisplaystring)|Retrieves the string displayed in a control container's property browser.|  
|[CPictureHolder::GetPictureDispatch](#cpictureholder__getpicturedispatch)|Returns the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface.|  
|[CPictureHolder::GetType](#cpictureholder__gettype)|Tells whether the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object is a bitmap, a metafile, or an icon.|  
|[CPictureHolder::Render](#cpictureholder__render)|Renders the picture.|  
|[CPictureHolder::SetPictureDispatch](#cpictureholder__setpicturedispatch)|Sets the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPictureHolder::m_pPict](#cpictureholder__m_ppict)|A pointer to a picture object.|  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> does not have a base class.  
  
 With the stock Picture property, the developer can specify a bitmap, icon, or metafile for display.  
  
 For information on creating custom picture properties, see the article [MFC ActiveX Controls: Using Pictures in an ActiveX Control](../vs140/mfc-activex-controls--using-pictures-in-an-activex-control.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
##  \<a name="cpictureholder__cpictureholder">\</a>  CPictureHolder::CPictureHolder  
 Constructs a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cpictureholder__createempty">\</a>  CPictureHolder::CreateEmpty  
 Creates an empty <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object and connects it to an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the object is successfully created; otherwise 0.  
  
##  \<a name="cpictureholder__createfrombitmap">\</a>  CPictureHolder::CreateFromBitmap  
 Uses a bitmap to initialize the picture object in a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Resource ID of a bitmap resource.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Pointer to a [CBitmap](../vs140/cbitmap-class.md) object.  
  
 *pPal*  
 Pointer to a [CPalette](../vs140/cpalette-class.md) object.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Indicates whether the picture object will take ownership of the bitmap and palette objects.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Handle to the bitmap from which the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object is created.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Handle to the palette used for rendering the bitmap.  
  
### Return Value  
 Nonzero if the object is successfully created; otherwise 0.  
  
### Remarks  
 If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is **TRUE**, the caller should not use the bitmap or palette object in any way after this call returns. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is **FALSE**, the caller is responsible for ensuring that the bitmap and palette objects remain valid for the lifetime of the picture object.  
  
##  \<a name="cpictureholder__createfromicon">\</a>  CPictureHolder::CreateFromIcon  
 Uses an icon to initialize the picture object in a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Resource ID of a bitmap resource.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Handle to the icon from which the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object is created.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Indicates whether the picture object will take ownership of the icon object.  
  
### Return Value  
 Nonzero if the object is successfully created; otherwise 0.  
  
### Remarks  
 If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is **TRUE**, the caller should not use the icon object in any way after this call returns. If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is **FALSE**, the caller is responsible for ensuring that the icon object remains valid for the lifetime of the picture object.  
  
##  \<a name="cpictureholder__createfrommetafile">\</a>  CPictureHolder::CreateFromMetafile  
 Uses a metafile to initialize the picture object in a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Handle to the metafile used to create the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
 *xExt*  
 X extent of the picture.  
  
 *yExt*  
 Y extent of the picture.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Indicates whether the picture object will take ownership of the metafile object.  
  
### Return Value  
 Nonzero if the object is successfully created; otherwise 0.  
  
### Remarks  
 If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is **TRUE**, the caller should not use the metafile object in any way after this call returns. If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is **FALSE**, the caller is responsible for ensuring that the metafile object remains valid for the lifetime of the picture object.  
  
##  \<a name="cpictureholder__getdisplaystring">\</a>  CPictureHolder::GetDisplayString  
 Retrieves the string that is displayed in a container's property browser.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Reference to the [CString](../vs140/cstringt-class.md) that is to hold the display string.  
  
### Return Value  
 Nonzero if the string is successfully retrieved; otherwise 0.  
  
##  \<a name="cpictureholder__getpicturedispatch">\</a>  CPictureHolder::GetPictureDispatch  
 This function returns a pointer to the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> interface.  
  
### Remarks  
 The caller must call **Release** on this pointer when finished with it.  
  
##  \<a name="cpictureholder__gettype">\</a>  CPictureHolder::GetType  
 Indicates whether the picture is a bitmap, metafile, or icon.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A value indicating the type of the picture. Possible values and their meanings are as follows:  
  
|Value|Meaning|  
|-----------|-------------|  
|**PICTYPE_UNINITIALIZED**|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object is unititialized.|  
|**PICTYPE_NONE**|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object is empty.|  
|**PICTYPE_BITMAP**|Picture is a bitmap.|  
|**PICTYPE_METAFILE**|Picture is a metafile.|  
|**PICTYPE_ICON**|Picture is an icon.|  
  
##  \<a name="cpictureholder__m_ppict">\</a>  CPictureHolder::m_pPict  
 A pointer to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cpictureholder__render">\</a>  CPictureHolder::Render  
 Renders the picture in the rectangle referenced by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Pointer to the display context in which the picture is to be rendered.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Rectangle in which the picture is to be rendered.  
  
 *rcWBounds*  
 A rectangle representing the bounding rectangle of the object rendering the picture. For a control, this rectangle is the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> parameter passed to an override of [COleControl::OnDraw](../vs140/colecontrol-class.md#colecontrol__ondraw).  
  
##  \<a name="cpictureholder__setpicturedispatch">\</a>  CPictureHolder::SetPictureDispatch  
 Connects the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object to a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Pointer to the new <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> interface.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontHolder](../vs140/cfontholder-class.md)