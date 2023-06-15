namespace PartialClass_Enum
{
    public class Book : BaseClass<Book>
    {
        public int Code { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string Cover { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public string Language { get; set; }
        
        public override Book Get(int id)
        {
            return new Book();
        }

        public override Book[] GetAll()
        {
            return new Book[10];
        }

        public override int Add(Book book)
        {
            return 1;
        }

        public override Book Update(Book book)
        {
            return new Book();
        }

        public override bool Delete(int id)
        {
            return true;
        }

        //Procedure method
        public void Method1()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method2()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method3()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method4()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method5()
        {
            /*
              Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
              Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
              when an unknown printer took a galley of type and scrambled it to make a type 
              specimen book. It has survived not only five centuries, but also the leap into 
              electronic typesetting, remaining essentially unchanged. It was popularised in
              the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
              and more recently with desktop publishing software like Aldus PageMaker including
              versions of Lorem Ipsum. publishing software like Aldus PageMaker including
              Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
              Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
              when an unknown printer took a galley of type and scrambled it to make a type 
              specimen book. It has survived not only five centuries, but also the leap into 
              electronic typesetting, remaining essentially unchanged. It was popularised in
              the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
              and more recently with desktop publishing software like Aldus PageMaker including
              versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
              Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
              when an unknown printer took a galley of type and scrambled it to make a type 
              specimen book. It has survived not only five centuries, but also the leap into 
              electronic typesetting, remaining essentially unchanged. It was popularised in
              the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
              and more recently with desktop publishing software like Aldus PageMaker including
              versions of Lorem Ipsum. publishing software like Aldus PageMaker including
              Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
              Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
              when an unknown printer took a galley of type and scrambled it to make a type 
              specimen book. It has survived not only five centuries, but also the leap into 
              electronic typesetting, remaining essentially unchanged. It was popularised in
              the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
              and more recently with desktop publishing software like Aldus PageMaker including
              versions of Lorem Ipsum.
              */
        }

        public void Method6()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method7()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method8()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method9()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        //Functional method
        public void Method10()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method11()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method12()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method13()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method14()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method15()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method16()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method17()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method18()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method19()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        //Other methods
        public void Method20()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method21()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method22()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method23()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method24()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method25()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method26()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method27()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method28()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method29()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }

        public void Method30()
        {
            /*
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.Lorem Ipsum is simply dummy text of the printing and
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum. publishing software like Aldus PageMaker including
             Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
             when an unknown printer took a galley of type and scrambled it to make a type 
             specimen book. It has survived not only five centuries, but also the leap into 
             electronic typesetting, remaining essentially unchanged. It was popularised in
             the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
             and more recently with desktop publishing software like Aldus PageMaker including
             versions of Lorem Ipsum.
             */
        }
    }
}
