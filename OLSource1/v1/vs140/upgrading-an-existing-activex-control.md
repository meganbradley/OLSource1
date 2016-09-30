---
title: "Upgrading an Existing ActiveX Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], Internet"
  - "LPK files for Internet controls"
  - "safe for scripting and initialization (controls)"
  - "OLE controls [C++], upgrading to ActiveX"
  - "CAB files, for ActiveX controls"
  - "Internet applications [C++], ActiveX controls"
  - "Internet applications [C++], packaging code for download"
  - "upgrading ActiveX controls"
  - "licensing ActiveX controls"
ms.assetid: 4d12ddfa-b491-4f9f-a0b7-b51458e05651
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Upgrading an Existing ActiveX Control
Existing ActiveX controls (formerly OLE controls) can be used on the Internet without modification. However, you may want to modify controls to improve their performance. When using your control on a Web page, there are additional considerations. The .ocx file and all supporting files must be on the target machine or be downloaded across the Internet. This makes code size and download time an important consideration. Downloads can be packaged in a signed .cab file. You can mark your control as safe for scripting, and as safe for initializing.  
  
 This article discusses the following topics:  
  
-   [Packaging Code for Downloading](#_core_packaging_code_for_downloading)  
  
-   [Marking a Control Safe for Scripting and Initializing](#_core_marking_a_control_safe_for_scripting_and_initializing)  
  
-   [Licensing Issues](#_core_licensing_issues)  
  
-   [Signing Code](#_core_signing_code)  
  
-   [Managing the Palette](#_core_managing_the_palette)  
  
-   [Internet Explorer Browser Safety Levels and Control Behavior](#_core_internet_explorer_browser_safety_levels_and_control_behavior)  
  
 You can also add optimizations, as described in [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md). Monikers can be used to download properties and large BLOBs asynchronously, as described in [ActiveX Controls on the Internet](../vs140/activex-controls-on-the-internet.md).  
  
##  \<a name="_core_packaging_code_for_downloading">\</a> Packaging Code for Downloading  
 For more information on this subject, see the Knowledge Base article "Packaging MFC Controls for Use Over the Internet" (Q167158). You can find Knowledge Base articles on the MSDN Library CD-ROM or at [http://support.microsoft.com/support](http://support.microsoft.com/support).  
  
### The CODEBASE Tag  
 ActiveX controls are embedded in Web pages using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> tag. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> tag specifies the location from which to download the control. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can point at a number of different file types successfully.  
  
### Using the CODEBASE Tag with an OCX File  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This solution downloads only the control's .ocx file, and requires any supporting DLLs to already be installed on the client machine. This will work for Internet Explorer and MFC ActiveX controls built with Visual C++, because Internet Explorer ships with the supporting DLLs for Visual C++ controls. If another Internet browser that is ActiveX control-capable is used to view this control, this solution will not work.  
  
### Using the CODEBASE Tag with an INF File  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An .inf file will control the installation of an .ocx and its supporting files. This method is not recommended because it is not possible to sign an .inf file (see [Signing Code](#_core_signing_code) for pointers on code signing).  
  
### Using the CODEBASE Tag with a CAB File  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Cabinet files are the recommended way to package ActiveX controls that use MFC. Packaging an MFC ActiveX control in a cabinet file allows an .inf file to be included to control installation of the ActiveX control and any dependent DLLs (such as the MFC DLLs). Using a CAB file automatically compresses the code for quicker download. If you are using a .cab file for component download, it is faster to sign the entire .cab file than each individual component.  
  
### Creating CAB Files  
 You can download the Cabinet Development Kit from the Knowledge Base article [310618: Microsoft Cabinet Software Development Kit](http://go.microsoft.com/fwlink/?LinkId=148204). In this kit you will find the necessary tools to construct cabinet files.  
  
 The cabinet file pointed to by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> should contain the .ocx file for your ActiveX control and an .inf file to control its installation. You create the cabinet file by specifying the name of your control file and an .inf file. Do not include dependent DLLs that may already exist on the system in this cabinet file. For example, the MFC DLLs are packaged in a separate cabinet file and referred to by the controlling .inf file.  
  
 For details on how to create a CAB file, see [Creating a CAB File](assetId:///cc52fd09-bdf6-4410-a693-149a308f36a3).  
  
### The INF File  
 The following example, spindial.inf, lists the supporting files and the version information needed for the MFC Spindial control. Notice the location for the MFC DLLs is a Microsoft Web site. The mfc42.cab is provided and signed by Microsoft.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### The \<OBJECT> Tag  
 The following example illustrates using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> tag to package the MFC Spindial sample control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In this case, spindial.cab will contain two files, spindial.ocx and spindial.inf. The following command will build the cabinet file:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter reserves space in the cabinet for code signing.  
  
### The Version Tag  
 Note here that the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> information specified with a CAB file applies to the control specified by the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> tag.  
  
 Depending on the version specified, you can force download of your control. For complete specifications of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> tag including the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter, see the W3C reference.  
  
##  \<a name="_core_marking_a_control_safe_for_scripting_and_initializing">\</a> Marking a Control Safe for Scripting and Initializing  
 ActiveX controls used in Web pages should be marked as safe for scripting and safe for initializing if they are in fact safe. A safe control will not perform disk IO or access the memory or registers of a machine directly.  
  
 Controls can be marked as safe for scripting and safe for initializing via the registry. Modify <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to add entries similar to the following to mark the control as safe for scripting and persistence in the registry. An alternative method is to implement <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 You will define GUIDs (Globally Unique Identifiers) for your control to mark it safe for scripting and for persistence. Controls that can be safely scripted will contain a registry entry similar to the following:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Controls that can be safely initialized from persistent data are marked safe for persistence with a registry entry similar to:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Add entries similar to the following (substituting your control's class ID in place of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>) to associate your keys with the following class ID:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="_core_licensing_issues">\</a> Licensing Issues  
 If you want to use a licensed control on a Web page, you must verify that the license agreement allows its use on the Internet and create a license package file (LPK) for it.  
  
 A licensed ActiveX control will not load properly in an HTML page if the computer running Internet Explorer is not licensed to use the control. For example, if a licensed control was built using Visual C++, the HTML page using the control will load properly on the computer where the control was built, but it will not load on a different computer unless licensing information is included.  
  
 To use a licensed ActiveX control in Internet Explorer, you must check the vendor's license agreement to verify that the license for the control permits:  
  
-   Redistribution  
  
-   Use of the control on the Internet  
  
-   Use of the Codebase parameter  
  
 To use a licensed control in an HTML page on a nonlicensed machine, you must generate a license package file (LPK). The LPK file contains run-time licenses for licensed controls in the HTML page. This file is generated via LPK_TOOL.EXE which comes with the ActiveX SDK. For more information, see the MSDN Web site at [http://msdn.microsoft.com](http://msdn.microsoft.com).  
  
#### To create an LPK file  
  
1.  Run LPK_TOOL.EXE on a computer that is licensed to use the control.  
  
2.  In the **License Package Authoring Tool** dialog box, in the **Available Controls** list box, select each licensed ActiveX control that will be used on the HTML page and click **Add**.  
  
3.  Click **Save & Exit** and type a name for the LPK file. This will create the LPK file and close the application.  
  
#### To embed a licensed control on an HTML page  
  
1.  Edit your HTML page. In the HTML page, insert an \<OBJECT> tag for the License Manager object before any other \<OBJECT> tags. The License Manager is an ActiveX control that is installed with Internet Explorer. Its class ID is shown below. Set the LPKPath property of the License Manager object to the path and name of the LPK file. You can have only one LPK file per HTML page.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
2.  Insert the \<OBJECT> tag for your licensed control after the License Manager tag.  
  
     For example, an HTML page that displays the Microsoft Masked Edit control is shown below. The first class ID is for the License Manager control, the second class ID is for the Masked Edit control. Change the tags to point to the relative path of the .lpk file you created earlier, and add an object tag including the class ID for your control.  
  
3.  Insert the \<EMBED> attribute for your LPK file, if using the NCompass ActiveX plug-in.  
  
     If your control may be viewed on other Active enabled browsers — for example, Netscape using the NCompass ActiveX plug-in — you must add the \<EMBED> syntax as shown below.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 For more information about control licensing, see [ActiveX Controls: Licensing an ActiveX Control](../vs140/mfc-activex-controls--licensing-an-activex-control.md).  
  
##  \<a name="_core_signing_code">\</a> Signing Code  
 Code signing is designed to identify the source of code, and to guarantee that the code has not changed since it was signed. Depending on browser safety settings, users may be warned before the code is downloaded. Users may choose to trust certain certificate owners or companies, in which case code signed by those trusted will be downloaded without warning. Code is digitally signed to avoid tampering.  
  
 Make sure your final code is signed so that your control can be automatically downloaded without displaying trust warning messages. For details on how to sign code, check the documentation on Authenticode in the ActiveX SDK and see [Signing a CAB File](assetId:///04d8b47a-8f1c-4b54-ab90-730fcdc03747).  
  
 Depending on trust and browser safety level settings, a certificate may be displayed to identify the signing person or company. If the safety level is none, or if the signed control's certificate owner is trusted, a certificate will not be displayed. See [Internet Explorer Browser Safety Levels and Control Behavior](#_core_internet_explorer_browser_safety_levels_and_control_behavior) for details on how the browser safety setting will determine whether your control is downloaded and a certificate displayed.  
  
 Digital signing guarantees code has not changed since it's been signed. A hash of the code is taken and embedded in the certificate. This hash is later compared with a hash of the code taken after the code is downloaded but before it runs. Companies such as Verisign can supply private and public keys needed to sign code. The ActiveX SDK ships with MakeCert, a utility for creating test certificates.  
  
##  \<a name="_core_managing_the_palette">\</a> Managing the Palette  
 Containers determine the palette and make it available as an ambient property, **DISPID_AMBIENT_PALETTE**. A container (for example, Internet Explorer) chooses a palette that is used by all ActiveX controls on a page to determine their own palette. This prevents display flickering and presents a consistent appearance.  
  
 A control can override <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to handle notification of changes to the palette.  
  
 A control can override <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to return a color set to draw the palette. Containers use the return value to determine if a control is palette-aware.  
  
 Under OCX 96 guidelines, a control must always realize its palette in the background.  
  
 Older containers that do not use the ambient palette property will send <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> messages. A control can override <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to handle these messages.  
  
##  \<a name="_core_internet_explorer_browser_safety_levels_and_control_behavior">\</a> Internet Explorer Browser Safety Levels and Control Behavior  
 A browser has options for safety level, configurable by the user. Because Web pages can contain active content that might potentially harm a user's computer, browsers allow the user to select options for safety level. Depending on the way a browser implements safety levels, a control may not be downloaded at all, or will display a certificate or a warning message to allow the user to choose at run time whether or not to download the control. The behavior of ActiveX controls under high, medium, and low safety levels on Internet Explorer is listed below.  
  
### High Safety Mode  
  
-   Unsigned controls will not be downloaded.  
  
-   Signed controls will display a certificate if untrusted (a user can choose an option to always trust code from this certificate owner from now on).  
  
-   Only controls marked as safe will have persistent data and/or be scriptable.  
  
### Medium Safety Mode  
  
-   Unsigned controls will display a warning before downloading.  
  
-   Signed controls will display a certificate if untrusted.  
  
-   Controls not marked as safe will display a warning.  
  
### Low Safety Mode  
  
-   Controls are downloaded without warning.  
  
-   Scripting and persistence occur without warning.  
  
## See Also  
 [MFC Internet Programming Tasks](../vs140/mfc-internet-programming-tasks.md)   
 [MFC Internet Programming Basics](../vs140/mfc-internet-programming-basics.md)   
 [MFC ActiveX Controls: Licensing an ActiveX Control](../vs140/mfc-activex-controls--licensing-an-activex-control.md)