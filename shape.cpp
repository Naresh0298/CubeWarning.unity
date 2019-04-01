#include<iostream>
using namespace std;

class shape
{
	public:
	virtual	void setdata()
		{
			cout<<"hello";
		
		}
		 virtual double getarea()
		{ 
		return 0;
		
		}
		 virtual double getperi()
		{ return 0;
		
		}
};
class rectangle:public shape
{
	private:
		double l,b;
	public:
		void setdata()
		{
			
			cout<< "\n enter l nd b:";
	       cin>>l>>b;
			
			
		}
		double getarea()
		{
			return l*b;
			
		}
		double  getperi()
		{
			return 2*(l+b);
			
		}
};
class square:public shape
{
	private:
		double a;
	public:
		void setdata()
		{
			cout<<"\n enter the  side:";
			cin>>a;
			
		}
		double getarea()
		{
			return a*a;
		}
		double getperi()
		{
			return 4*a;
		}
};

/* int main()
{
	shape *s;
	rectangle r;
    square s1;
    s=&r;
    s->setdata();
    cout<<"\n area of the rectangle is"<<s->getarea();
    cout<<"\n perimeter of the rectangle is:"<<s->getperi();
    s=&s1;
    s->setdata();
    cout<<"\n the area of square is"<<s->getarea();
    cout<<"\n the perimeter of squaure is"<<s->getperi();
    return 0;
  
  
  shape *p;
  int ch;
  cout<<"\n enter your choice:";
  cin>>ch;
  if(ch%2==0)
  {
  	p=new rectangle();
  	
	}
	else 
	p=new square();
	p->setdata();
	cout<<"\n area is:"<<p->getarea();
	cout<<"\n the perimeter is"<<p->getperi();
	delete p;
	return 0;
	  
}*/
shape*factory()
{
	int ch;
	cout<<"\n enter your choice: ";
	cin>>ch;
	if(ch%2==0)
	return(new rectangle());
	else
	return(new square());
}

int main()
{
shape*p;
int i;
for(int i=1;i<=10;i++)
{
p=factory();
p->setdata();
cout<<"\n the area is"<<p->getarea();
cout<<"\n the perimeter is "<<p->getperi();
return 0;
}
}
