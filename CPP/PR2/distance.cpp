#include <iostream>
#include <cmath>
#include <iomanip>

class Point
        {
        friend double distanceFrom(Point point1, Point point2);
        private:
            double m_a = 0.0;
            double m_b = 0.0;
        public:
            Point() {
                this->m_a = 0.0;
                this->m_b = 0.0;
            }
            Point(double m_a, double m_b) {
                this->m_a = m_a;
                this->m_b = m_b;
            }
            void Print ()
            {
                std::cout << "Point(" << m_a << "," << m_b << ")\n";
            }

        };

        double distanceFrom(Point point1, Point point2) {
            double a1 = point1.m_a;
            double b1 = point1.m_b;
            double a2 = point2.m_a;
            double b2 = point2.m_b;

            double distance = sqrt((a1 - a2) * (a1 - a1) + (b1 - b2) * (b1 - b2));
            return distance;
        }
            int main()
            {
                Point first;
                Point second(2.0, 5.0);
                first.Print();
                second.Print();
                std::cout << "Distance between two points: " << distanceFrom(first, second) << std::endl;
            }
