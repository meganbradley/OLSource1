---
title: "Define a profile to extend UML"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "profiles, UML"
  - "stereotypes, UML"
  - "UML, profiles and stereotypes"
  - "UML - extending, defining profiles"
  - "UML, customizing"
  - "UML, profiles"
ms.assetid: 776589cb-f89d-48d5-aafa-04a4c074b0d6
caps.latest.revision: 46
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Define a profile to extend UML
You can define a *UML profile* to customize the standard model elements for specific purposes. A profile defines one or more *UML stereotypes*. A stereotype can be used to mark a type as representing a particular kind of object. A stereotype can also extend an element's list of properties.  
  
 Several profiles are installed with supported editions of Visual Studio. To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport). For more information about those profiles and about how to apply stereotypes, see [Customizing Your Model with Profiles and Stereotypes](../vs140/customize-your-model-with-profiles-and-stereotypes.md).  
  
 You can define your own profiles to adapt and extend UML to your own business area or architecture. For example:  
  
-   If you frequently define Web sites, you could define your own profile that provides a «WebPage» stereotype that can be applied to classes in class diagrams. You could then use class diagrams to plan a Web site. Every «WebPage» class would have extra properties for page content, style, and so on.  
  
-   If you develop banking software, you could define a profile that provides an «Account» stereotype. You could then use class diagrams to define different types of account and show the relationships between them.  
  
 You can distribute your own profiles to your team. Each team member can install your profile. This enables them to edit and create models that use its stereotypes.  
  
> [!NOTE]
>  If you apply the stereotypes of a profile in a model that you are editing, and then share the model with other people, they should install the same profile on their own computers. Otherwise, they will not be able to see the stereotypes that you have used.  
  
 A profile is often part of a larger [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] extension. For example, you could define a command that translates some parts of a model to code. You could define a profile that users must apply to packages that they want to translate. You would distribute your new command together with the profile in a single [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] extension.  
  
 You can also define localized variants of a profile. Users loading your extension see the variant that is appropriate to their own culture.  
  
##  \<a name="DefineProfile">\</a> How to Define a Profile  
  
#### To define a UML Profile  
  
1.  Create a new XML file with the file name extension <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
2.  Add stereotype definitions according to the guidelines described in [The Structure of a Profile](#Schema).  
  
3.  Add the profile to a Visual Studio Extension (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> file). You can either create a new extension for your profile, or add the profile to an existing extension.  
  
     See the next section, [How to Add a Profile to a Visual Studio Extension](#AddProfile).  
  
4.  Install the extension on your computer.  
  
    1.  Double-click the extension file, which has a file name extension <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
    2.  Restart Visual Studio.  
  
5.  Verify that the profile has been installed.  
  
    1.  Select the model in UML Explorer.  
  
    2.  In the Properties window, click the **Profiles** property. Your profile will appear in the menu. Set the check mark next to the profile.  
  
    3.  Select an element for which your profile defines stereotypes. In the Properties window, click the **Stereotypes** property. Your stereotypes will appear in the list. Set the check mark against one of the stereotypes.  
  
    4.  If your profile defines additional properties for this stereotype, expand the stereotype property to see them.  
  
6.  Send the extension file to other users of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to install on their computers.  
  
##  \<a name="AddProfile">\</a> How to Add a Profile to a Visual Studio Extension  
 To install a profile, and to allow you to send it to other users, you must add the profile to a Visual Studio extension. For more information, see [Deploying Visual Studio Extensions](http://go.microsoft.com/fwlink/?LinkId=160780).  
  
#### To define a profile in a new Visual Studio Extension  
  
1.  Create a Visual Studio Extension project.  
  
    > [!NOTE]
    >  You must have installed [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] to use this procedure.  
  
    1.  On the **File** menu, point to **New**, and then click **Project**.  
  
    2.  In the **New Project** dialog box, under **Installed Templates**, expand **Visual C#**, click **Extensibility**, and then click **VSIX project**. Set the project name and click **OK**.  
  
2.  Add your profile to the project.  
  
    -   In Solution Explorer, right-click the project, point to **Add**, and then click **Existing Item**. In the dialog box, locate your profile file.  
  
3.  Set the profile file's **Copy to Output** property.  
  
    1.  In Solution Explorer, right-click the profile file, and then click **Properties**.  
  
    2.  In the Properties window, set the **Copy to Output Directory** property to **Copy Always**.  
  
4.  In Solution Explorer, open <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
     The file opens in the extension manifest editor.  
  
5.  On the **Assets** page, add a row describing the profile:  
  
    -   Click **New**. Set the fields in the **Add New Asset** dialog as follows.  
  
    -   Set **Type** to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
         This is not one of the drop-down choices. Enter this name from the keyboard.  
  
    -   Click **File on filesystem** and select the name of your profile file, for example <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
6.  Build the project.  
  
7.  **To debug the profile**, press F5.  
  
     An experimental instance of Visual Studio opens. In this instance, open a modeling project. In UML Explorer, select the root element of the model, and in the Properties window, select your profile. Then select elements inside the model and set stereotypes that you have defined for them.  
  
8.  **To extract the VSIX for deployment**  
  
    1.  In Windows Explorer, open the folder **.\bin\Debug** or **.\bin\Release** to find the **.vsix** file. This is a [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] Extension file. It can be installed on your computer and sent to other Visual Studio users.  
  
    2.  To install the extension:  
  
        1.  Double-click the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> file. The Visual Studio Extension Installer will start.  
  
        2.  Restart any instances of Visual Studio that are running.  
  
 The following alternative procedure can be used for small extensions if you have not installed [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)].  
  
#### To define a profile extension without using Visual Studio SDK  
  
1.  Create a Windows directory that contains the following three files:  
  
    -   *YourProfile* <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> - type this name as shown here, with the square brackets  
  
2.  Edit <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to contain the following text. Notice that it contains an entry for each file name extension.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Copy an existing <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and edit it with an XML editor. Alter the ID, Name, and Content nodes.  
  
    -   You can find an example of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in this directory:  
  
         *drive* **:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\UmlProfiles**  
  
    -   The Content node should be like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Compress the three files into a zipped file.  
  
     In Windows Explorer, select the three files, right-click, point to **Send To**, and then click **Compressed (zipped) folder**.  
  
5.  Rename the zipped file, and change its file name extension from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
6.  To install the profile on any computer with appropriate editions of Visual Studio, double-click the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> file.  
  
#### To install a UML Profile from a Visual Studio Extension  
  
1.  Double-click the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> file in Windows Explorer, or open it within Visual Studio.  
  
2.  Click **Install** in the dialog box that appears.  
  
3.  To uninstall or temporarily disable the extension, open **Extensions and Updates** from the **Tools** menu.  
  
##  \<a name="Localized">\</a> How to Define Localized Profiles  
 You can define different profiles for different cultures or languages, and package them all into the same extension. When a user loads your extension, they will see the profile that you have defined for their culture.  
  
 You must always provide a default profile. If you have not defined a profile for the user's culture, they will see the default profile.  
  
#### To define a localized profile  
  
1.  Create a profile as described in the previous sections[How to Define a Profile](#DefineProfile) and [How to Add a Profile to a Visual Studio Extension](#AddProfile). This is the default profile, and will be used in any installation for which you do not provide a localized profile.  
  
2.  Add a new directory in the same directory as your default profile file.  
  
    > [!NOTE]
    >  If you are building the extension by using a Visual Studio Extension project, use Solution Explorer to add a new folder to the project.  
  
3.  Change the new directory's name to the ISO short code for the localized culture, such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for Bulgarian, or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> for French. You should use a neutral culture code, typically two letters, not a specific culture such as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information about culture codes, see [CultureInfo.GetCultures method](http://go.microsoft.com/fwlink/?LinkId=160782), which provides a complete list of culture codes.  
  
4.  Add a copy of your default profile to the new directory. Do not change its file name.  
  
     A sample [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] Extension folder, before it is built or compressed into a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> file, would contain the following folders and files:  
  
     <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  You should not insert into <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> a reference to the localized versions of the profiles. The copied profile files must have the same name as the profile in the parent folder.  
  
5.  Edit the new copy of the profile, translating to the target language all the parts that will be visible to the user, such as the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attributes.  
  
6.  You can create additional culture folders and localized profiles for as many cultures as you want.  
  
7.  Build the Visual Studio extension, either by building the Extension Project or compressing all the files, as described in the previous sections.  
  
##  \<a name="Schema">\</a> The Structure of a Profile  
 The XSD file for UML profiles can be found in the following sample: [Setting Stereotypes and Profiles XSD](http://go.microsoft.com/fwlink/?LinkID=213811). To help you edit profile files, install the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> file in:  
  
 **%ProgramFiles%\Microsoft Visual Studio [version]\Xml\Schemas**  
  
 This section uses the C# profile as an example. The complete profile definition can be seen in:  
  
 *drive* **:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\UmlProfiles\CSharp.profile**  
  
 The first parts of this path might differ in your installation.  
  
 For more information about the .NET profile, see [Standard Stereotypes for UML Models](../vs140/standard-stereotypes-for-uml-models.md).  
  
### Main sections of the UML Profile definition  
 Every profile contains the following content:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!NOTE]
>  The attribute called <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> must not contain spaces or punctuation. The attribute <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, which appears in the user interface, should be a valid XML string.  
  
 Every profile contains three main sections. In reverse order, they are as follows:  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> - a list of types that are used for properties defined in the stereotypes section.  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> - a list of model element types to which the stereotypes in this profile apply, such as IClass, IInterface, IOperation, IDependency.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> - the stereotype definitions. Each definition includes the names and types of properties that are added to the target model element.  
  
#### Property Types  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> section declares a list of types that are used for properties in the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> section. There are two kinds of property types: external and enumeration.  
  
 An external type declares the fully qualified name of a standard .NET type:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An enumeration type defines a set of literal values:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
#### Metaclasses  
 The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> section is a list of model element types to which stereotypes in this profile can be defined:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For the full list of model element and relationship types that you can use as metaclasses, see [Model Element Types](#Elements).  
  
#### Stereotype definition  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> section contains one or more stereotype definitions:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Each stereotype lists one or more model element or relationship types to which it can be applied. You can give the name of a base type, to include all its derived types. For example, if you specify <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, the stereotype can be applied to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, and several other types of element.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> attribute of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is a link to an element in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> section.  
  
> [!NOTE]
>  The moniker name must begin with <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is defined in the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> attribute of the profile ("CSharpProfile" in this example). The moniker ends with the name of one of the entries in the metaclasses section.  
  
 Each stereotype can list zero or more properties that it adds to any model element to which it is applied. The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> contains a link to one of the types that are defined in the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> section. The link must be either an <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to refer to an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> or an <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to refer to an <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. Again, the link begins with the name of your profile.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="Elements">\</a> Model Element Types  
 The set of types for which you can define stereotypes is listed in [Model Element Types](../vs140/uml-model-element-types.md).  
  
## Troubleshooting  
 My stereotypes do not appear my UML models.  
 You have to select your profile in a package or model. The stereotypes will then appear on elements inside the package or model. For more information, see [How to: Add Stereotypes to Model Elements](../vs140/add-stereotypes-to-uml-model-elements.md).  
  
 The following error appears when I open a UML model: **VS1707: The following profiles cannot be loaded because a serialization error occurred: MyProfile.profile**  
 1.  Verify that the basic XML syntax of the .profile is correct.  
  
2.  Ensure that each Moniker name is in the form /profileName/nodeName. The profileName is the value of the name attribute in the root profile node. The nodeName is the value of the name attribute of a metaclass, externalType, or enumerationType.  
  
3.  Ensure the syntax is as described here, and as demonstrated in *drive***:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\UmlProfiles\\**.  
  
4.  Uninstall the faulty extension. On the **Tools** menu, click **Extensions and Updates**.  
  
    -   If the extension does not appear, see the next item.  
  
5.  Rebuild the VSIX file and open it in Windows Explorer to re-install it. Restart [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 The extension does not appear in Extension Manager, but when you try to re-install it, the following message appears: **The extension is already installed to all applicable products.**  
 1.  Remove the extension file from a subfolder of *LocalAppData*\Microsoft\VisualStudio\\[version]\Extensions\  
  
    -   To see *LocalAppData*, you must set Show Hidden Files and Folders in the View tab of the Windows Explorer Folder Options.  
  
    -   *LocalAppData* is typically in C:Users*userName*AppDataLocal  
  
2.  Restart [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## See Also  
 [How to: Add Stereotypes to Model Elements](../vs140/add-stereotypes-to-uml-model-elements.md)   
 [Customizing Your Model with Profiles and Stereotypes](../vs140/customize-your-model-with-profiles-and-stereotypes.md)   
 [Standard Stereotypes for UML Models](../vs140/standard-stereotypes-for-uml-models.md)   
 [Sample: Color UML Elements by Stereotype](http://go.microsoft.com/fwlink/?LinkID=213841)   
 [Sample: Setting Stereotypes, Profiles XSD](http://go.microsoft.com/fwlink/?LinkID=213811)