cmake_minimum_required(VERSION 3.19.2)
project(UnitTest VERSION 0.1.0 LANGUAGES C CXX)

add_executable(UnitTest main.cpp)

enable_testing()

add_subdirectory(googletest)
target_link_libraries(UnitTest gtest_main gmock_main)