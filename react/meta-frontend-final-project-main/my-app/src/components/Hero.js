import React from "react";
import {Box, Flex, SimpleGrid, Image, ChakraProvider, Heading } from "@chakra-ui/react";

const Hero = () => {
  return (
    <ChakraProvider>
    <Box backgroundColor="#495E57" p={10}>
      <div>
        <Flex
          margin="0 auto"
          px={12}
          color="#fff"
          justifyContent="center"
          alignItems="center"
          maxWidth="1024px"
          height={260}
          
        >
          <SimpleGrid columns={3} spacing={10} id="heroText">
            <Box bg='#495E57' height='40px'><Heading id="title" as='h1' size="2xl">Little Lemon</Heading></Box>
            <Box bg='#495E57' height='40px'></Box>
            <Box bg='#495E57' height='40px' display="grid" placeItems="center"><Image src="./icons_assets/2/resturantchefB.png" alt="chef" width="50px"></Image></Box>
            <Box bg='#495E57' height='40px'><Heading id="branch" as='h3' size="lg">Chicago</Heading></Box>
            <Box bg='#495E57' height='40px'></Box>
            <Box bg='#495E57' height='40px'></Box>
            <Box bg='#F4CE14' height='40px' borderRadius={10} color="black" display="grid" placeItems="center"><a className="button" href="">Book a Table</a></Box>
            <Box bg='#F4CE14' height='40px' borderRadius={10} color="black" display="grid" placeItems="center"><a className="button" href="">Order Online</a></Box>
            <Box bg='#495E57' height='40px'></Box>
          </SimpleGrid>
        </Flex>
      </div>
    </Box>
    </ChakraProvider>
  );
};
export default Hero;