//기본
#include <stdio.h>

int main()
{
    return 0;
}

//출력
    printf("명사");

//줄바꿈
    printf("명사\n");

//탭키 만큼 공백
    printf("명사\t");

//(정수)변수 지정
//형식지정자 %d
    int 명사 /*const 상수선언*/
    명사 = 수;

    int 명사 = 수;

    int level;
    level = 1;

//(실수)변수 지정
//형식지정자 %f
    float 변수 = 수f; /*소수 6자리까지*/
    double 변수 = 수;  /*소수 15자리까지, const 상수선언*/
%.수f /*출력은 수에 따라 소수점 달라짐*/

//입력받기
//입력 받는 변수 : int 변수;
    scanf("형식지정자", &변수);

//덧셈(정수, 실수, 둘다)
    printf("변수1 + 변수2 = 형식지정자", 변수1 + 변수2);
//뺄셈(정수, 실수, 둘다)
    printf("변수1 - 변수2 = 형식지정자\n", 변수1-변수2);
    printf("변수2 - 변수1 = 형식지정자", 변수2-변수1);
//곱셈(정수, 실수, 둘다)
    printf("변수1 * 변수2 = 형식지정자", 변수1*변수2);
//나눗셈(정수, 실수, 둘다)
    printf("변수1 / 변수2 = 형식지정자", 변수1/변수2);
//나머지(정수)
    printf("변수1 %% 변수2 = 형식지정자", 변수1%변수2);

//전위 연산자
    printf("형식지정사\n", ++변수); /*변수 1 증가*/
    printf("형식지정사", 변수); /*1 증가된 변수 출력*/
    printf("형식지정사\n", --변수); /*변수 1 감소*/
    printf("형식지정사", 변수); /*1 감소된 변수 출력*/
//후위 연산자
    printf("형식지정사\n", 변수++); /*변수 출력 후*/
    printf("형식지정사", 변수); /*1 증가된 변수 출력*/
    printf("형식지정사\n", 변수--); /*변수 출력 후*/
    printf("형식지정사", 변수); /*1 감소된 변수 출력*/

비교 연산자
== /*같다*/
!= /*다르다*/
< /*크다*/
> /*작다*/
<= /*크거나 같다*/
>= /*작거나 같다*/

//논리곱(&&, AND), 참이면 1출력 거짓이면 0출력(조건 모두 만족)
int number = 5;
    printf("AND : number 는 3보다 크다. 그리고 10보다 작다. : %d\n", 3 < number && number < 10); 
    printf("AND : number 는 3보다 크다. 그리고 10보다 크다. : %d\n", 3 < number && 10 < number);
//논리합(||, OR), 참이면 1출력 거짓이면 0출력(조건 중 1개라도 만족)
    printf("OR : number 는 5 이거나 4 이다. : %d\n", number == 5 || number == 4);
    printf("OR : number 는 6 이거나 7 이다. : %d\n", number == 6 || number == 7);

//복합 대입 연산자
    int 변수 = 수;

    변수 += 수;
    printf("형식지정자", 변수);
    변수 -= 수;
    printf("형식지정자", 변수);
    변수 *= 수;
    printf("형식지정자", 변수);
    변수 /= 수;
    printf("형식지정자", 변수);
    변수 %= 수;
    printf("형식지정자", 변수);

//비트 연산자(int main의 함수 칸에 void입력)
& /*AND*/
    unsigned char 변수1 = 수;
    unsigned char 변수2 = 수;
    unsigned char 변수3 = 변수1 & 변수2;
| /*OR*/
    unsigned char 변수1 = 수;
    unsigned char 변수2 = 수;
    unsigned char 변수3 = 변수1 | 변수2;
^ /*XOR*/
    unsigned char 변수1 = 수;
    unsigned char 변수2 = 수;
    unsigned char 변수3 = 변수1 ^ 변수2;
~ /*NOT, 모든 비트 반전*/
    unsigned char 변수1 = 수;
    unsigned char 변수2 = 수;
    unsigned char 변수3 = ~변수1;
    unsigned char 변수4 = ~변수2;
<< /*지정 수 만큼 비트 열 왼쪽 이동*/
>> /*지정 수 만큼 비트 열 오른쪽 이동*/
