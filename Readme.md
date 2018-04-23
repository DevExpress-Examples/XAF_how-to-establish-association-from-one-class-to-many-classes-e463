# How to establish association from one class to many classes


<p>For instance, you have a class for File. This class will be used in more than one BO. Each BO would then have a listview of Files that are attached to the particular class.<br> To accomplish this, you can create a super class, say DomainObjectBase and then establish a one-to-many relationship between the File class. After that you can derive your BOs from the DomainObjectBase class and they will automatically get the parent's relationships.<br><br><strong>NOTE:</strong><br>Here the optional "abstract" keyword is also used to indicate that the base class is not directly instantiated in the application and instead its descendants are used (XPO still creates a physical table for the abstract class data in the database and thus allows all relationships to be correctly defined). Of course, you can remove the "abstract" keyword from the code if this is not needed according to your business requirements.</p>

<br/>


