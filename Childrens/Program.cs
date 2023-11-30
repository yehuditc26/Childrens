var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//ילדים childrens
//גן Kindergarten
//גננת Kindergarten Teacher


// Configure the HTTP request pipeline.

app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*
 * שליפת רשימת התינוקות

GET https://tipa.co.il/babies

שליפת תינוק לפי מזהה

GET https://tipa.co.il/babies/1

הוספת תינוק

POST https://tipa.co.il/babies

עדכון תינוק

PUT https://tipa.co.il/babies/1

מיפוי Routes לאחיות
שליפת רשימת האחיות

GET https://tipa.co.il/nurses

שליפת אחות לפי מזהה

GET https://tipa.co.il/nurses/1

הוספת אחות

POST https://tipa.co.il/nurses

עדכון אחות

PUT https://tipa.co.il/nurses/1

מיפוי Routes לתורים
שליפת רשימת התורים

GET https://tipa.co.il/turns

שליפת תור לפי מזהה

GET https://tipa.co.il/turns/1

הוספת תור

POST https://tipa.co.il/turns

עדכון תור

PUT https://tipa.co.il/turns/1

מחיקת תור

DELETE https://tipa.co.il/turns/1

בחרתי לא למפות Routes למחיקת תינוק ואחות. במקום זה אוסיף Routes לעדכון סטטוס

PUT https://tipa.co.il/babies/1/status

PUT https://tipa.co.il/nurses/1/status
 */
