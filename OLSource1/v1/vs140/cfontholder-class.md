---
title: "CFontHolder Class"
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
  - "CFontHolder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "custom fonts"
  - "CFontHolder class"
  - "fonts, ActiveX controls"
ms.assetid: 728ab472-0c97-440d-889f-1324c6e1b6b8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontHolder Class
Implements the stock Font property and encapsulates the functionality of a Windows font object and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFontHolder::CFontHolder](#cfontholder__cfontholder)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFontHolder::GetDisplayString](#cfontholder__getdisplaystring)|Retrieves the string displayed in a container's property browser.|  
|[CFontHolder::GetFontDispatch](#cfontholder__getfontdispatch)|Returns the font's <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface.|  
|[CFontHolder::GetFontHandle](#cfontholder__getfonthandle)|Returns a handle to a Windows font.|  
|[CFontHolder::InitializeFont](#cfontholder__initializefont)|Initializes a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[CFontHolder::QueryTextMetrics](#cfontholder__querytextmetrics)|Retrieves information for the related font.|  
|[CFontHolder::ReleaseFont](#cfontholder__releasefont)|Disconnects the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object from the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interfaces.|  
|[CFontHolder::Select](#cfontholder__select)|Selects a font resource into a device context.|  
|[CFontHolder::SetFont](#cfontholder__setfont)|Connects the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> interface.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFontHolder::m_pFont](#cfontholder__m_pfont)|A pointer to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface.|  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> does not have a base class.  
  
 Use this class to implement custom font properties for your control. For information on creating such properties, see the article [ActiveX Controls: Using Fonts](../vs140/mfc-activex-controls--using-fonts.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
##  \<a name="cfontholder__cfontholder">\</a>  CFontHolder::CFontHolder  
 Constructs a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pNotify*  
 Pointer to the font's <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> interface.  
  
### Remarks  
 You must call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to initialize the resulting object before using it.  
  
##  \<a name="cfontholder__getdisplaystring">\</a>  CFontHolder::GetDisplayString  
 Retrieves a string that can be displayed in a container's property browser.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Reference to the [CString](../vs140/cstringt-class.md) that is to hold the display string.  
  
### Return Value  
 Nonzero if the string is successfully retrieved; otherwise 0.  
  
##  \<a name="cfontholder__getfontdispatch">\</a>  CFontHolder::GetFontDispatch  
 Call this function to retrieve a pointer to the font's dispatch interface.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object's **IFontDisp** interface. Note that the function that calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> must call <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> on this interface pointer when done with it.  
  
### Remarks  
 Call <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="cfontholder__getfonthandle">\</a>  CFontHolder::GetFontHandle  
 Call this function to get a handle to a Windows font.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Height, in logical units, of the rectangle in which the control is drawn.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Height, in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> units, of the control.  
  
### Return Value  
 A handle to the Font object; otherwise **NULL**.  
  
### Remarks  
 The ratio of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is used to calculate the proper display size, in logical units, for the font's point size expressed in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> units:  
  
 Display size = ( <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>) X font size  
  
 The version with no parameters returns a handle to a font sized correctly for the screen.  
  
##  \<a name="cfontholder__initializefont">\</a>  CFontHolder::InitializeFont  
 Initializes a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Pointer to a font description structure (                                [FONTDESC](http://msdn.microsoft.com/library/windows/desktop/ms692782)) that specifies the font's characteristics.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Pointer to the container's ambient Font property.  
  
### Remarks  
 If <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is not **NULL**, the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object is connected to a clone of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> interface used by the container's ambient Font property.  
  
 If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is **NULL**, a new Font object is created either from the font description pointed to by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or, if <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is **NULL**, from a default description.  
  
 Call this function after constructing a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
##  \<a name="cfontholder__m_pfont">\</a>  CFontHolder::m_pFont  
 A pointer to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="cfontholder__querytextmetrics">\</a>  CFontHolder::QueryTextMetrics  
 Retrieves information on the physical font represented by the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to a                                 [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure that will receive the information.  
  
##  \<a name="cfontholder__releasefont">\</a>  CFontHolder::ReleaseFont  
 This function disconnects the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object from its <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="cfontholder__select">\</a>  CFontHolder::Select  
 Call this function to select your control's font into the specified device context.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Device context into which the font is selected.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Height, in logical units, of the rectangle in which the control is drawn.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Height, in <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> units, of the control.  
  
### Return Value  
 A pointer to the font that is being replaced.  
  
### Remarks  
 See [GetFontHandle](#cfontholder__getfonthandle) for a discussion of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameters.  
  
##  \<a name="cfontholder__setfont">\</a>  CFontHolder::SetFont  
 Releases any existing font and connects the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pNewFont*  
 Pointer to the new <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> interface.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropExchange](../vs140/cpropexchange-class.md)