---
title: "CStockPropImpl Class"
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
  - "CStockPropImpl"
  - "ATL::CStockPropImpl"
  - "ATL.CStockPropImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStockPropImpl class"
  - "controls [ATL], stock properties"
  - "stock properties, ATL controls"
ms.assetid: 45f11d7d-6580-4a0e-872d-3bc8b836cfda
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl Class
This class provides methods for supporting stock property values.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The class implementing the control and deriving from <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A dual interface exposing the stock properties.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to the IID of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A pointer to the LIBID of the type library containing the definition of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The major version of the type library. The default value is 1.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The minor version of the type library. The default value is 0.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The class used to manage the type information for <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Methods  
  
|||  
|-|-|  
|[get_Appearance](../vs140/cstockpropimpl--get_appearance.md)|Call this method to get the paint style used by the control, for example, flat or 3D.|  
|[get_AutoSize](../vs140/cstockpropimpl--get_autosize.md)|Call this method to get the status of the flag that indicates if the control cannot be any other size.|  
|[get_BackColor](../vs140/cstockpropimpl--get_backcolor.md)|Call this method to get the control's background color.|  
|[get_BackStyle](../vs140/cstockpropimpl--get_backstyle.md)|Call this method to get the control's background style, either transparent or opaque.|  
|[get_BorderColor](../vs140/cstockpropimpl--get_bordercolor.md)|Call this method to get the control's border color.|  
|[get_BorderStyle](../vs140/cstockpropimpl--get_borderstyle.md)|Call this method to get the control's border style.|  
|[get_BorderVisible](../vs140/cstockpropimpl--get_bordervisible.md)|Call this method to get the status of the flag that indicates if the control's border is visible or not.|  
|[get_BorderWidth](../vs140/cstockpropimpl--get_borderwidth.md)|Call this method to get the width (in pixels) of the control's border.|  
|[get_Caption](../vs140/cstockpropimpl--get_caption.md)|Call this method to get the text specified in an object's caption.|  
|[get_DrawMode](../vs140/cstockpropimpl--get_drawmode.md)|Call this method to get the control's drawing mode, for example, XOR Pen or Invert Colors.|  
|[get_DrawStyle](../vs140/cstockpropimpl--get_drawstyle.md)|Call this method to get the control's drawing style, for example, solid, dashed, or dotted.|  
|[get_DrawWidth](../vs140/cstockpropimpl--get_drawwidth.md)|Call this method to get the drawing width (in pixels) used by the control's drawing methods.|  
|[get_Enabled](../vs140/cstockpropimpl--get_enabled.md)|Call this method to get the status of the flag that indicates if the control is enabled.|  
|[get_FillColor](../vs140/cstockpropimpl--get_fillcolor.md)|Call this method to get the control's fill color.|  
|[get_FillStyle](../vs140/cstockpropimpl--get_fillstyle.md)|Call this method to get the control's fill style, for example, solid, transparent, or cross-hatched.|  
|[get_Font](../vs140/cstockpropimpl--get_font.md)|Call this method to get a pointer to the control's font properties.|  
|[get_ForeColor](../vs140/cstockpropimpl--get_forecolor.md)|Call this method to get the control's foreground color.|  
|[get_HWND](../vs140/cstockpropimpl--get_hwnd.md)|Call this method to get the window handle associated with the control.|  
|[get_MouseIcon](../vs140/cstockpropimpl--get_mouseicon.md)|Call this method to get the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control.|  
|[get_MousePointer](../vs140/cstockpropimpl--get_mousepointer.md)|Call this method to get the type of mouse pointer displayed when the mouse is over the control, for example, arrow, cross, or hourglass.|  
|[get_Picture](../vs140/cstockpropimpl--get_picture.md)|Call this method to get a pointer to the picture properties of a graphic (icon, bitmap, or metafile) to be displayed.|  
|[get_ReadyState](../vs140/cstockpropimpl--get_readystate.md)|Call this method to get the control's ready state, for example, loading or loaded.|  
|[get_TabStop](../vs140/cstockpropimpl--get_tabstop.md)|Call this method to get the flag that indicates if the control is a tab stop or not.|  
|[get_Text](../vs140/cstockpropimpl--get_text.md)|Call this method to get the text that is displayed with the control.|  
|[get_Valid](../vs140/cstockpropimpl--get_valid.md)|Call this method to get the status of the flag that indicates if the control is valid or not.|  
|[get_Window](../vs140/cstockpropimpl--get_window.md)|Call this method to get the window handle associated with the control. Identical to [CStockPropImpl::get_HWND](../vs140/cstockpropimpl--get_hwnd.md).|  
|[put_Appearance](../vs140/cstockpropimpl--put_appearance.md)|Call this method to set the paint style used by the control, for example, flat or 3D.|  
|[put_AutoSize](../vs140/cstockpropimpl--put_autosize.md)|Call this method to set the value of the flag that indicates if the control cannot be any other size.|  
|[put_BackColor](../vs140/cstockpropimpl--put_backcolor.md)|Call this method to set the control's background color.|  
|[put_BackStyle](../vs140/cstockpropimpl--put_backstyle.md)|Call this method to set the control's background style.|  
|[put_BorderColor](../vs140/cstockpropimpl--put_bordercolor.md)|Call this method to set the control's border color.|  
|[put_BorderStyle](../vs140/cstockpropimpl--put_borderstyle.md)|Call this method to set the control's border style.|  
|[put_BorderVisible](../vs140/cstockpropimpl--put_bordervisible.md)|Call this method to set the value of the flag that indicates if the control's border is visible or not.|  
|[put_BorderWidth](../vs140/cstockpropimpl--put_borderwidth.md)|Call this method to set the width of the control's border.|  
|[put_Caption](../vs140/cstockpropimpl--put_caption.md)|Call this method to set the text to be displayed with the control.|  
|[put_DrawMode](../vs140/cstockpropimpl--put_drawmode.md)|Call this method to set the control's drawing mode, for example, XOR Pen or Invert Colors.|  
|[put_DrawStyle](../vs140/cstockpropimpl--put_drawstyle.md)|Call this method to set the control's drawing style, for example, solid, dashed, or dotted.|  
|[put_DrawWidth](../vs140/cstockpropimpl--put_drawwidth.md)|Call this method to set the width (in pixels) used by the control's drawing methods.|  
|[put_Enabled](../vs140/cstockpropimpl--put_enabled.md)|Call this method to set the flag that indicates if the control is enabled.|  
|[put_FillColor](../vs140/cstockpropimpl--put_fillcolor.md)|Call this method to set the control's fill color.|  
|[put_FillStyle](../vs140/cstockpropimpl--put_fillstyle.md)|Call this method to set the control's fill style, for example, solid, transparent, or cross-hatched.|  
|[put_Font](../vs140/cstockpropimpl--put_font.md)|Call this method to set the control's font properties.|  
|[put_ForeColor](../vs140/cstockpropimpl--put_forecolor.md)|Call this method to set the control's foreground color.|  
|[put_HWND](../vs140/cstockpropimpl--put_hwnd.md)|This method returns E_FAIL.|  
|[put_MouseIcon](../vs140/cstockpropimpl--put_mouseicon.md)|Call this method to set the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control.|  
|[put_MousePointer](../vs140/cstockpropimpl--put_mousepointer.md)|Call this method to set the type of mouse pointer displayed when the mouse is over the control, for example, arrow, cross, or hourglass.|  
|[put_Picture](../vs140/cstockpropimpl--put_picture.md)|Call this method to set the picture properties of a graphic (icon, bitmap, or metafile) to be displayed.|  
|[put_ReadyState](../vs140/cstockpropimpl--put_readystate.md)|Call this method to set the control's ready state, for example, loading or loaded.|  
|[put_TabStop](../vs140/cstockpropimpl--put_tabstop.md)|Call this method to set the value of the flag that indicates if the control is a tab stop or not.|  
|[put_Text](../vs140/cstockpropimpl--put_text.md)|Call this method to set the text that is displayed with the control.|  
|[put_Valid](../vs140/cstockpropimpl--put_valid.md)|Call this method to set the flag that indicates if the control is valid or not.|  
|[put_Window](../vs140/cstockpropimpl--put_window.md)|This method calls [CStockPropImpl::put_HWND](../vs140/cstockpropimpl--put_hwnd.md), which returns E_FAIL.|  
|[putref_Font](../vs140/cstockpropimpl--putref_font.md)|Call this method to set the control's font properties, with a reference count.|  
|[putref_MouseIcon](../vs140/cstockpropimpl--putref_mouseicon.md)|Call this method to set the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control, with a reference count.|  
|[putref_Picture](../vs140/cstockpropimpl--putref_picture.md)|Call this method to set the picture properties of a graphic (icon, bitmap, or metafile) to be displayed, with a reference count.|  
  
## Remarks  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> provides **put** and **get** methods for each stock property. These methods provide the code necessary to set or get the data member associated with each property and to notify and synchronize with the container when any property changes.  
  
 Visual C++ provides support for stock properties through its wizards. For more information about adding stock properties to a control, see the [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md).  
  
 For backward compatibility, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> also exposes <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> methods that simply call <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, respectively. The default implementation of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> returns **E_FAIL** since <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> should be a read-only property.  
  
 The following properties also have a **putref** implementation:  
  
-   Font  
  
-   MouseIcon  
  
-   Picture  
  
 The same three stock properties require their corresponding data member to be of type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or some other class that provides correct interface reference counting by means of the assignment operator.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
 [IDispatchImpl](../vs140/idispatchimpl-class.md)  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="cstockpropimpl__get_appearance">\</a>  CStockPropImpl::get_Appearance  
 Call this method to get the paint style used by the control, for example, flat or 3D.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pnAppearance*  
 Variable that receives the control's paint style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_autosize">\</a>  CStockPropImpl::get_AutoSize  
 Call this method to get the status of the flag that indicates if the control cannot be any other size.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pbAutoSize*  
 Variable that receives the flag status. TRUE indicates that the control cannot be any other size.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_backcolor">\</a>  CStockPropImpl::get_BackColor  
 Call this method to get the control's background color.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *pclrBackColor*  
 Variable that receives the control's background color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_backstyle">\</a>  CStockPropImpl::get_BackStyle  
 Call this method to get the control's background style, either transparent or opaque.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *pnBackStyle*  
 Variable that receives the control's background style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_bordercolor">\</a>  CStockPropImpl::get_BorderColor  
 Call this method to get the control's border color.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pclrBorderColor*  
 Variable that receives the control's border color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_borderstyle">\</a>  CStockPropImpl::get_BorderStyle  
 Call this method to get the control's border style.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *pnBorderStyle*  
 Variable that receives the control's border style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_bordervisible">\</a>  CStockPropImpl::get_BorderVisible  
 Call this method to get the status of the flag that indicates if the control's border is visible or not.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *pbBorderVisible*  
 Variable that receives the flag status. TRUE indicates that the control's border is visible.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_borderwidth">\</a>  CStockPropImpl::get_BorderWidth  
 Call this method to get the width of the control's border.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *pnBorderWidth*  
 Variable that receives the control's border width.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_caption">\</a>  CStockPropImpl::get_Caption  
 Call this method to get the text specified in an object's caption.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *pbstrCaption*  
 The text to be displayed with the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_drawmode">\</a>  CStockPropImpl::get_DrawMode  
 Call this method to get the control's drawing mode, for example, XOR Pen or Invert Colors.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pnDrawMode*  
 Variable that receives the control's drawing mode.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_drawstyle">\</a>  CStockPropImpl::get_DrawStyle  
 Call this method to get the control's drawing style, for example, solid, dashed, or dotted.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *pnDrawStyle*  
 Variable that receives the control's drawing style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_drawwidth">\</a>  CStockPropImpl::get_DrawWidth  
 Call this method to get the drawing width (in pixels) used by the control's drawing methods.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *pnDrawWidth*  
 Variable that receives the control's width value, in pixels.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_enabled">\</a>  CStockPropImpl::get_Enabled  
 Call this method to get the status of the flag that indicates if the control is enabled.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Variable that receives the flag status. TRUE indicates that the control is enabled.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_fillcolor">\</a>  CStockPropImpl::get_FillColor  
 Call this method to get the control's fill color.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *pclrFillColor*  
 Variable that receives the control's fill color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_fillstyle">\</a>  CStockPropImpl::get_FillStyle  
 Call this method to get the control's fill style, for example, solid, transparent, or crosshatched.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *pnFillStyle*  
 Variable that receives the control's fill style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_font">\</a>  CStockPropImpl::get_Font  
 Call this method to get a pointer to the control's font properties.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Variable that receives a pointer to the control's font properties.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_forecolor">\</a>  CStockPropImpl::get_ForeColor  
 Call this method to get the control's foreground color.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *pclrForeColor*  
 Variable that receives the controls foreground color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_hwnd">\</a>  CStockPropImpl::get_HWND  
 Call this method to get the window handle associated with the control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The window handle associated with the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_mouseicon">\</a>  CStockPropImpl::get_MouseIcon  
 Call this method to get the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Variable that receives a pointer to the picture properties of the graphic.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_mousepointer">\</a>  CStockPropImpl::get_MousePointer  
 Call this method to get the type of mouse pointer displayed when the mouse is over the control, for example, arrow, cross, or hourglass.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *pnMousePointer*  
 Variable that receives the type of mouse pointer.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_picture">\</a>  CStockPropImpl::get_Picture  
 Call this method to get a pointer to the picture properties of a graphic (icon, bitmap, or metafile) to be displayed.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Variable that receives a pointer to the picture's properties. See [IPictureDisp](http://msdn.microsoft.com/library/windows/desktop/ms680762) for more details.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_readystate">\</a>  CStockPropImpl::get_ReadyState  
 Call this method to get the control's ready state, for example, loading or loaded.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *pnReadyState*  
 Variable that receives the control's ready state.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_tabstop">\</a>  CStockPropImpl::get_TabStop  
 Call this method to get the status of the flag that indicates if the control is a tab stop or not.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 *pbTabStop*  
 Variable that receives the flag status. TRUE indicates that the control is a tab stop.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_text">\</a>  CStockPropImpl::get_Text  
 Call this method to get the text that is displayed with the control.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 *pbstrText*  
 The text that is displayed with the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_valid">\</a>  CStockPropImpl::get_Valid  
 Call this method to get the status of the flag that indicates if the control is valid or not.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *pbValid*  
 Variable that receives the flag status. TRUE indicates that the control is valid.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__get_window">\</a>  CStockPropImpl::get_Window  
 Call this method to get the window handle associated with the control. Identical to [CStockPropImpl::get_HWND](../vs140/cstockpropimpl--get_hwnd.md).  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The window handle associated with the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_appearance">\</a>  CStockPropImpl::put_Appearance  
 Call this method to set the paint style used by the control, for example, flat or 3D.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The new paint style to be used by the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_autosize">\</a>  CStockPropImpl::put_AutoSize  
 Call this method to set the value of flag that indicates if the control cannot be any other size.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *bAutoSize*  
 TRUE if the control cannot be any other size.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_backcolor">\</a>  CStockPropImpl::put_BackColor  
 Call this method to set the control's background color.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 *clrBackColor*  
 The new control background color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_backstyle">\</a>  CStockPropImpl::put_BackStyle  
 Call this method to set the control's background style.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 *nBackStyle*  
 The new control background style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_bordercolor">\</a>  CStockPropImpl::put_BorderColor  
 Call this method to set the control's border color.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *clrBorderColor*  
 The new border color. The OLE_COLOR data type is internally represented as a 32-bit long integer.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_borderstyle">\</a>  CStockPropImpl::put_BorderStyle  
 Call this method to set the control's border style.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 *nBorderStyle*  
 The new border style.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_bordervisible">\</a>  CStockPropImpl::put_BorderVisible  
 Call this method to set the value of the flag that indicates if the control's border is visible or not.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 *bBorderVisible*  
 TRUE if the border is to be visible.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_borderwidth">\</a>  CStockPropImpl::put_BorderWidth  
 Call this method to set the width of the control's border.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The new width of the control's border.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_caption">\</a>  CStockPropImpl::put_Caption  
 Call this method to set the text to be displayed with the control.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 *bstrCaption*  
 The text to be displayed with the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_drawmode">\</a>  CStockPropImpl::put_DrawMode  
 Call this method to set the control's drawing mode, for example, XOR Pen or Invert Colors.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The new drawing mode for the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_drawstyle">\</a>  CStockPropImpl::put_DrawStyle  
 Call this method to set the control's drawing style, for example, solid, dashed, or dotted.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 *nDrawStyle*  
 The new drawing style for the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_drawwidth">\</a>  CStockPropImpl::put_DrawWidth  
 Call this method to set the width (in pixels) used by the control's drawing methods.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 *nDrawWidth*  
 The new width to be used by the control's drawing methods.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_enabled">\</a>  CStockPropImpl::put_Enabled  
 Call this method to set the value of the flag that indicates if the control is enabled.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 TRUE if the control is enabled.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_fillcolor">\</a>  CStockPropImpl::put_FillColor  
 Call this method to set the control's fill color.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 *clrFillColor*  
 The new fill color for the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_fillstyle">\</a>  CStockPropImpl::put_FillStyle  
 Call this method to set the control's fill style, for example, solid, transparent, or cross-hatched.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *nFillStyle*  
 The new fill style for the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_font">\</a>  CStockPropImpl::put_Font  
 Call this method to set the control's font properties.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to the control's font properties.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_forecolor">\</a>  CStockPropImpl::put_ForeColor  
 Call this method to set the control's foreground color.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 *clrForeColor*  
 The new foreground color of the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_hwnd">\</a>  CStockPropImpl::put_HWND  
 This method returns E_FAIL.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 */\* hWnd \*/*  
 Reserved.  
  
### Return Value  
 Returns E_FAIL.  
  
### Remarks  
 The window handle is a read-only value.  
  
##  \<a name="cstockpropimpl__put_mouseicon">\</a>  CStockPropImpl::put_MouseIcon  
 Call this method to set the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 A pointer to the picture properties of the graphic.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_mousepointer">\</a>  CStockPropImpl::put_MousePointer  
 Call this method to set the type of mouse pointer displayed when the mouse is over the control, for example, arrow, cross, or hourglass.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 *nMousePointer*  
 The type of mouse pointer.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_picture">\</a>  CStockPropImpl::put_Picture  
 Call this method to set the picture properties of a graphic (icon, bitmap, or metafile) to be displayed.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A pointer to the picture's properties. See [IPictureDisp](http://msdn.microsoft.com/library/windows/desktop/ms680762) for more details.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_readystate">\</a>  CStockPropImpl::put_ReadyState  
 Call this method to set the control's ready state, for example, loading or loaded.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 *nReadyState*  
 The control's ready state.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_tabstop">\</a>  CStockPropImpl::put_TabStop  
 Call this method to set the flag that indicates if the control is a tab stop or not.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 *bTabStop*  
 TRUE if the control is a tab stop.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_text">\</a>  CStockPropImpl::put_Text  
 Call this method to set the text that is displayed with the control.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The text that is displayed with the control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_valid">\</a>  CStockPropImpl::put_Valid  
 Call this method to set the flag that indicates if the control is valid or not.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 *bValid*  
 TRUE if the control is valid.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="cstockpropimpl__put_window">\</a>  CStockPropImpl::put_Window  
 This method calls [CStockPropImpl::put_HWND](../vs140/cstockpropimpl--put_hwnd.md), which returns E_FAIL.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The window handle.  
  
### Return Value  
 Returns E_FAIL.  
  
### Remarks  
 The window handle is a read-only value.  
  
##  \<a name="cstockpropimpl__putref_font">\</a>  CStockPropImpl::putref_Font  
 Call this method to set the control's font properties, with a reference count.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A pointer to the control's font properties.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The same as [CStockPropImpl::put_Font](../vs140/cstockpropimpl--put_font.md), but with a reference count.  
  
##  \<a name="cstockpropimpl__putref_mouseicon">\</a>  CStockPropImpl::putref_MouseIcon  
 Call this method to set the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control, with a reference count.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A pointer to the picture properties of the graphic.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The same as [CStockPropImpl::put_MouseIcon](../vs140/cstockpropimpl--put_mouseicon.md), but with a reference count.  
  
##  \<a name="cstockpropimpl__putref_picture">\</a>  CStockPropImpl::putref_Picture  
 Call this method to set the picture properties of a graphic (icon, bitmap, or metafile) to be displayed, with a reference count.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A pointer to the picture's properties. See [IPictureDisp](http://msdn.microsoft.com/library/windows/desktop/ms680762) for more details.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The same as [CStockPropImpl::put_Picture](../vs140/cstockpropimpl--put_picture.md), but with a reference count.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [IDispatchImpl Class](../vs140/idispatchimpl-class.md)