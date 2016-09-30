---
title: "CPageSetupDialog Class"
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
  - "CPageSetupDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "page setup"
  - "Print Setup dialog box"
  - "Page Setup dialog box"
  - "OLE Page Setup dialog box"
  - "CPageSetupDialog class"
ms.assetid: 049c0ac8-f254-4854-9414-7a8271d1447a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPageSetupDialog Class
Encapsulates the services provided by the Windows common OLE Page Setup dialog box with additional support for setting and modifying print margins.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPageSetupDialog::CPageSetupDialog](#cpagesetupdialog__cpagesetupdialog)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPageSetupDialog::CreatePrinterDC](#cpagesetupdialog__createprinterdc)|Creates a device context for printing.|  
|[CPageSetupDialog::DoModal](#cpagesetupdialog__domodal)|Displays the dialog box and allows the user make a selection.|  
|[CPageSetupDialog::GetDeviceName](#cpagesetupdialog__getdevicename)|Returns the device name of the printer.|  
|[CPageSetupDialog::GetDevMode](#cpagesetupdialog__getdevmode)|Returns the current <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> of the printer.|  
|[CPageSetupDialog::GetDriverName](#cpagesetupdialog__getdrivername)|Returns the driver used by the printer.|  
|[CPageSetupDialog::GetMargins](#cpagesetupdialog__getmargins)|Returns the current margin settings of the printer.|  
|[CPageSetupDialog::GetPaperSize](#cpagesetupdialog__getpapersize)|Returns the paper size of the printer.|  
|[CPageSetupDialog::GetPortName](#cpagesetupdialog__getportname)|Returns the output port name.|  
|[CPageSetupDialog::OnDrawPage](#cpagesetupdialog__ondrawpage)|Called by the framework to render a screen image of a printed page.|  
|[CPageSetupDialog::PreDrawPage](#cpagesetupdialog__predrawpage)|Called by the framework before rendering a screen image of a printed page.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPageSetupDialog::m_psd](#cpagesetupdialog__m_psd)|A structure used to customize a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 This class is designed to take the place of the Print Setup dialog box.  
  
 To use a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object, first create the object using the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> constructor. Once the dialog box has been constructed, you can set or modify any values in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data member to initialize the values of the dialog box's controls. The [m_psd](#cpagesetupdialog__m_psd) structure is of type **PAGESETUPDLG**.  
  
 After initializing the dialog box controls, call the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function to display the dialog box and allow the user to select print options. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns whether the user selected the OK ( **IDOK**) or Cancel ( **IDCANCEL**) button.  
  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> returns **IDOK**, you can use several of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>'s member functions, or access the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> data member, to retrieve information input by the user.  
  
> [!NOTE]
>  After the common OLE Page Setup dialog box is dismissed, any changes made by the user will not be saved by the framework. It is up to the application itself to save any values from this dialog box to a permanent location, such as member of the application's document or application class.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="cpagesetupdialog__cpagesetupdialog">\</a>  CPageSetupDialog::CPageSetupDialog  
 Call this function to construct a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 One or more flags you can use to customize the settings of the dialog box. The values can be combined using the bitwise-OR operator. These values have the following meanings:  
  
-   **PSD_DEFAULTMINMARGINS** Sets the minimum allowable widths for the page margins to be the same as the printer's minimums. This flag is ignored if the **PSD_MARGINS** and **PSD_MINMARGINS** flags are also specified.  
  
-   **PSD_INWININIINTLMEASURE** Not implemented.  
  
-   **PSD_MINMARGINS** Causes the system to use the values specified in the **rtMinMargin** member as the minimum allowable widths for the left, top, right, and bottom margins. The system prevents the user from entering a width that is less than the specified minimum. If **PSD_MINMARGINS** is not specified, the system sets the minimum allowable widths to those allowed by the printer.  
  
-   **PSD_MARGINS** Activates the margin control area.  
  
-   **PSD_INTHOUSANDTHSOFINCHES** Causes the units of the dialog box to be measured in 1/1000 of an inch.  
  
-   **PSD_INHUNDREDTHSOFMILLIMETERS** Causes the units of the dialog box to be measured in 1/100 of a millimeter.  
  
-   **PSD_DISABLEMARGINS** Disables the margin dialog box controls.  
  
-   **PSD_DISABLEPRINTER** Disables the Printer button.  
  
-   **PSD_NOWARNING** Prevents the warning message from being displayed when there is no default printer.  
  
-   **PSD_DISABLEORIENTATION** Disables the page orientation dialog control.  
  
-   **PSD_RETURNDEFAULT** Causes <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to return                                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures that are initialized for the system default printer without displaying a dialog box. It is assumed that both **hDevNames** and **hDevMode** are **NULL**; otherwise, the function returns an error. If the system default printer is supported by an old printer driver (earlier than Windows version 3.0), only **hDevNames** is returned; **hDevMode** is **NULL**.  
  
-   **PSD_DISABLEPAPER** Disables the paper selection control.  
  
-   **PSD_SHOWHELP** Causes the dialog box to show the Help button. The **hwndOwner** member must not be **NULL** if this flag is specified.  
  
-   **PSD_ENABLEPAGESETUPHOOK** Enables the hook function specified in **lpfnSetupHook**.  
  
-   **PSD_ENABLEPAGESETUPTEMPLATE** Causes the operating system to create the dialog box by using the dialog template box identified by **hInstance** and **lpSetupTemplateName**.  
  
-   **PSD_ENABLEPAGESETUPTEMPLATEHANDLE** Indicates that **hInstance** identifies a data block that contains a preloaded dialog box template. The system ignores **lpSetupTemplateName** if this flag is specified.  
  
-   **PSD_ENABLEPAGEPAINTHOOK** Enables the hook function specified in **lpfnPagePaintHook**.  
  
-   **PSD_DISABLEPAGEPAINTING** Disables the draw area of the dialog box.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Pointer to the dialog box's parent or owner.  
  
### Remarks  
 Use the [DoModal](../vs140/cdialog-class.md#cdialog__domodal) function to display the dialog box.  
  
### Example  
 [!code[NVC_MFCDocView#94](../vs140/codesnippet/CPP/cpagesetupdialog-class_1.cpp)]  
  
##  \<a name="cpagesetupdialog__createprinterdc">\</a>  CPageSetupDialog::CreatePrinterDC  
 Creates a printer device context from the                 [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Handle to the newly created printer device context (DC).  
  
##  \<a name="cpagesetupdialog__domodal">\</a>  CPageSetupDialog::DoModal  
 Call this function to display the Windows common OLE Page Setup dialog box and allow the user to select various print setup options such as the printing margins, size and orientation of the paper, and destination printer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows                         [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
### Remarks  
 In addition, the user can access the printer setup options such as network location and properties specific to the selected printer.  
  
 If you want to initialize the various Page Setup dialog options by setting members of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> structure, you should do so before calling <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and after the dialog object is constructed. After calling <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
 If you want to propagate the current settings entered by the user, make a call to [CWinApp::SelectPrinter](../vs140/cwinapp-class.md#cwinapp__selectprinter). This function takes the information from the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object and initializes and selects a new printer DC with the proper attributes.  
  
 [!code[NVC_MFCDocView#95](../vs140/codesnippet/CPP/cpagesetupdialog-class_2.cpp)]  
  
### Example  
  See the example for [CPageSetupDialog::CPageSetupDialog](#cpagesetupdialog__cpagesetupdialog).  
  
##  \<a name="cpagesetupdialog__getdevicename">\</a>  CPageSetupDialog::GetDeviceName  
 Call this function after <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to retrieve the name of the currently selected printer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The device name used by the  **CPageSetupDialog** object.  
  
##  \<a name="cpagesetupdialog__getdevmode">\</a>  CPageSetupDialog::GetDevMode  
 Call this function after calling <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to retrieve information about the printer device context of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) data structure, which contains information about the device initialization and environment of a print driver. You must unlock the memory taken by this structure with the Windows                         [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595) function, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cpagesetupdialog__getdrivername">\</a>  CPageSetupDialog::GetDriverName  
 Call this function after calling [DoModal](../vs140/cprintdialog-class.md#cprintdialog__domodal) to retrieve the name of the system-defined printer device driver.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> specifying the system-defined driver name.  
  
### Remarks  
 Use a pointer to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc-class.md#cdc__createdc).  
  
##  \<a name="cpagesetupdialog__getmargins">\</a>  CPageSetupDialog::GetMargins  
 Call this function after a call to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to retrieve the margins of the printer device driver.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *lpRectMargins*  
 Pointer to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that describes (in 1/1000 inches or 1/100 mm) the print margins for the currently selected printer. Pass **NULL** for this parameter, if you are not interested in this rectangle.  
  
 *lpRectMinMargins*  
 Pointer to a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object that describes (in 1/1000 inches or 1/100 mm) the minimum print margins for the currently selected printer. Pass **NULL** for this parameter, if you are not interested in this rectangle.  
  
##  \<a name="cpagesetupdialog__getpapersize">\</a>  CPageSetupDialog::GetPaperSize  
 Call this function to retrieve the size of the paper selected for printing.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A [CSize](../vs140/csize-class.md) object containing the size of the paper (in 1/1000 inches or 1/100 mm) selected for printing.  
  
##  \<a name="cpagesetupdialog__getportname">\</a>  CPageSetupDialog::GetPortName  
 Call this function after calling <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to retrieve the name of the currently selected printer port.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The name of the currently selected printer port.  
  
##  \<a name="cpagesetupdialog__m_psd">\</a>  CPageSetupDialog::m_psd  
 A structure of type **PAGESETUPDLG**, whose members store the characteristics of the dialog object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 After constructing a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object, you can use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to set various aspects of the dialog box before calling the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> member function.  
  
 If you modify the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> data member directly, you will override any default behavior.  
  
 For more information on the                         [PAGESETUPDLG](http://msdn.microsoft.com/library/windows/desktop/ms646842) structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 See the example for [CPageSetupDialog::CPageSetupDialog](#cpagesetupdialog__cpagesetupdialog).  
  
##  \<a name="cpagesetupdialog__ondrawpage">\</a>  CPageSetupDialog::OnDrawPage  
 Called by the framework to draw a screen image of a printed page.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Pointer to the printer device context.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies a message, indicating the area of the page currently being drawn. Can be one of the following:  
  
-   **WM_PSD_FULLPAGERECT** The entire page area.  
  
-   **WM_PSD_MINMARGINRECT** Current minimum margins.  
  
-   **WM_PSD_MARGINRECT** Current margins.  
  
-   **WM_PSD_GREEKTEXTRECT** Contents of the page.  
  
-   **WM_PSD_ENVSTAMPRECT** Area reserved for a postage stamp representation.  
  
-   **WM_PSD_YAFULLPAGERECT** Area for a return address representation. This area extends to the edges of the sample page area.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to a [CRect](../vs140/crect-class.md) or [RECT](../vs140/rect-structure.md) object containing the coordinates of the drawing area.  
  
### Return Value  
 Nonzero value if handled; otherwise 0.  
  
### Remarks  
 This image is then displayed as part of the common OLE Page Setup dialog box. The default implementation draws an image of a page of text.  
  
 Override this function to customize the drawing of a specific area of the image, or the entire image. You can do this by using a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> statement with **case** statements checking the value of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. For example, to customize the rendering of the contents of the page image, you could use the following example code:  
  
 [!code[NVC_MFCDocView#96](../vs140/codesnippet/CPP/cpagesetupdialog-class_3.cpp)]  
  
 Note that you do not need to handle every case of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. You can choose to handle one component of the image, several components of the image, or the whole area.  
  
##  \<a name="cpagesetupdialog__predrawpage">\</a>  CPageSetupDialog::PreDrawPage  
 Called by the framework before drawing the screen image of a printed page.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *wPaper*  
 Specifies a value that indicates the paper size. This value can be one of the **DMPAPER_** values listed in the description of the                                 [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) structure.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Indicates the orientation of the paper or envelope, and whether the printer is a dot-matrix or HPPCL (Hewlett Packard Printer Control Language) device. This parameter can have one of the following values:  
  
-   0x001   Paper in landscape mode (dot matrix)  
  
-   0x003   Paper in landscape mode (HPPCL)  
  
-   0x005   Paper in portrait mode (dot matrix)  
  
-   0x007   Paper in portrait mode (HPPCL)  
  
-   0x00b   Envelope in landscape mode (HPPCL)  
  
-   0x00d   Envelope in portrait mode (dot matrix)  
  
-   0x019   Envelope in landscape mode (dot matrix)  
  
-   0x01f   Envelope in portrait mode (dot matrix)  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Pointer to a **PAGESETUPDLG** structure. For more information on                                 [PAGESETUPDLG](http://msdn.microsoft.com/library/windows/desktop/ms646842), see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Nonzero value if handled; otherwise 0.  
  
### Remarks  
 Override this function to customize the drawing of the image. If you override this function and return **TRUE**, you must draw the entire image. If you override this function and return **FALSE**, the entire default image is drawn by the framework.  
  
## See Also  
 [MFC Sample WORDPAD](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)