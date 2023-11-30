var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//����� childrens
//�� Kindergarten
//���� Kindergarten Teacher


// Configure the HTTP request pipeline.

app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*
 * ����� ����� ��������

GET https://tipa.co.il/babies

����� ����� ��� ����

GET https://tipa.co.il/babies/1

����� �����

POST https://tipa.co.il/babies

����� �����

PUT https://tipa.co.il/babies/1

����� Routes ������
����� ����� ������

GET https://tipa.co.il/nurses

����� ���� ��� ����

GET https://tipa.co.il/nurses/1

����� ����

POST https://tipa.co.il/nurses

����� ����

PUT https://tipa.co.il/nurses/1

����� Routes ������
����� ����� ������

GET https://tipa.co.il/turns

����� ��� ��� ����

GET https://tipa.co.il/turns/1

����� ���

POST https://tipa.co.il/turns

����� ���

PUT https://tipa.co.il/turns/1

����� ���

DELETE https://tipa.co.il/turns/1

����� �� ����� Routes ������ ����� �����. ����� �� ����� Routes ������ �����

PUT https://tipa.co.il/babies/1/status

PUT https://tipa.co.il/nurses/1/status
 */
