#include <iostream>
#include "googletest/googlemock/include/gmock/gmock.h"
#include "googletest/googletest/include/gtest/gtest.h"

int Sum(int a, int b) {return a + b;}

TEST(TestGroupName, Subtest_1){
    ASSERT_TRUE(Sum(2,3) == 5);
}

int main(int argc, char **argv){
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}
