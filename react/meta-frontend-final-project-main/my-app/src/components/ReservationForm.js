import * as React from 'react'
import { useState } from 'react';
import { Form, useFormik } from "formik";
import {
 Box,
 SimpleGrid,
 Flex,
 Heading,
 FormLabel,
 FormControl,
 FormErrorMessage,
 Input,
 Textarea,
 VStack,
 HStack,
 Button,
 Select,
 ChakraProvider
} from "@chakra-ui/react";
import * as Yup from 'yup';

const getCurrentDate = () => {
    const today = new Date();
    const year = today.getFullYear();
    let month = today.getMonth() + 1; // Months are 0-indexed
    let day = today.getDate();

    if (month < 10) {
      month = `0${month}`;
    }
    if (day < 10) {
      day = `0${day}`;
    }
    return `${year}-${month}-${day}`;
  };


const ReservationForm = () => {

    const [formData, setFormData] = useState({
        firstName: '',
        lastName: '',
        email: '',
        phoneNumber: '',
        date: '',
        time: '',
        partySize: '',
        type: '',
        notes: '',
      });


    const formik = useFormik({

            initialValues: formData,
            validationSchema: Yup.object({ 
                firstName: Yup.string().required("Required"), lastName: Yup.string().required("Required"),
                email: Yup.string().email("Invalid email address").required("Required"),
                phoneNumber: Yup.string().required("Required"), date: Yup.date().required("Required"),
                time: Yup.string().required("Requred"), partySize: Yup.string().required("Required"),
                notes: Yup.string().min(25, "Must be at least 25 characters"),
              }),
            onSubmit: (values) => {
                console.log("Form submitted:", values);
            },
    });

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData((prevFormData) => ({
          ...prevFormData,
          [name]: value,
        }));
        formik.handleChange(e); // Call formik's handleChange to handle validation
      };

    return (
        <ChakraProvider>
        <Flex 
          margin="0 auto"
          px={0}
          color="#000"
          justifyContent="center"
          alignItems="center"
          maxWidth="1024px"
          height="100vh"
          flexDirection="column"
        >
            <Box mb={8}>
            <Heading as="h2" id="reservation-section">Reservation Form</Heading>
            </Box>
            <HStack p={10}>




            <VStack width={{ base: "100%", md: "48%" }} spacing={4}>
                <FormControl isInvalid={!!formik.errors.firstName && formik.touched.firstName}>
                <FormLabel htmlFor="firstName">First Name</FormLabel>
                <Input id="firstName" name="firstName" value={formData.firstName} onChange={handleInputChange}/>
                <FormErrorMessage>{formik.errors.firstName}</FormErrorMessage>
                </FormControl>
                <FormControl isInvalid={!!formik.errors.lastName && formik.touched.lastName}>
                <FormLabel htmlFor="lastName">Last Name</FormLabel>
                <Input id="lastName" name="lastName" value={formData.lastName} onChange={handleInputChange}/>
                <FormErrorMessage>{formik.errors.lastName}</FormErrorMessage>
                </FormControl>

                <FormControl isInvalid={!!formik.errors.email && formik.touched.email}>
                    <FormLabel htmlFor="email">Email Address</FormLabel>
                    <Input id="email" name="email" type="email" value={formData.email} onChange={handleInputChange} />
                    <FormErrorMessage>{formik.errors.email}</FormErrorMessage>
                </FormControl>

                <FormControl isInvalid={!!formik.errors.phoneNumber && formik.touched.phoneNumber}>
                <FormLabel htmlFor="phoneNumber">Phone Number</FormLabel>
                <Input id="phoneNumber" name="phoneNumber" value={formData.email} onChange={handleInputChange}/>
                <FormErrorMessage>{formik.errors.phoneNumber}</FormErrorMessage>
                </FormControl>
            </VStack>

            <VStack width={{ base: "100%", md: "48%" }} spacing={4}>

                <FormControl isInvalid={!!formik.errors.date && formik.touched.date}>
                <FormLabel htmlFor="date">Date</FormLabel>
                <Input id="date" type="date" name="date" onChange={handleInputChange} onBlur={formik.handleBlur} value={formik.values.date} min={getCurrentDate()}/>
                <FormErrorMessage>{formik.touched.date && formik.errors.date}</FormErrorMessage>
                </FormControl>

                <FormControl>
                <FormLabel htmlFor="type">Time</FormLabel>
                <Select id="time" name="time" value={formData.time} onChange={handleInputChange}>
                 <option value="default">Select a Time</option>
                 <option value="17:00">17:00</option>
                 <option value="18:00">18:00</option>
                 <option value="19:00">19:00</option>
                 <option value="20:00">20:00</option>
                 <option value="21:00">21:00</option>
                 <option value="22:00">22:00</option>
               </Select>
               </FormControl>

                <FormControl isInvalid={!!formik.errors.partySize && formik.touched.partySize}>
                <FormLabel htmlFor="partySize">Party Size</FormLabel>
                <Input type="number" placeholder='1' id="partySize" name="partySize" min="1" max="10" value={formData.partySize} onChange={handleInputChange}/>
                <FormErrorMessage>{formik.touched.partySize && formik.errors.partySize}</FormErrorMessage>
                </FormControl>
                <FormControl>
                <FormLabel htmlFor="type">Occasion</FormLabel>
                <Select id="type" name="type" value={formData.type} onChange={handleInputChange}>
                 <option value="default">Select Occasion</option>
                 <option value="wedding">Wedding</option>
                 <option value="anneversary">Anneversary</option>
                 <option value="graduation">Graduation</option>
                 <option value="birthday">Birthday</option>
                 <option value="other">Other</option>
               </Select>
               </FormControl>
               </VStack>


               </HStack>

               <HStack p={0}>
               <Box mt={0} width="100%">
            <FormLabel htmlFor="notes">Notes</FormLabel>
                <Textarea
                 id="notes"
                 name="notes"
                 height={50}
                 value={formData.notes} onChange={handleInputChange}
               />
            </Box>

            <Box mt={8}>
            <Button type="submit" colorScheme="purple" width="full" onClick={formik.handleSubmit}>Submit</Button>
            </Box>
             </HStack>
             <HStack p={0}></HStack>
        </Flex>
        </ChakraProvider>
    )
}
export default ReservationForm;











{/* <SimpleGrid columns={1} spacing={20}>
                <Box><h3>Reservations</h3></Box>
            </SimpleGrid>
            <SimpleGrid columns={2} spacing={10}>
                <Box bg='#fff' height='30px'><Input placeholder='First Name' size='lg' width="auto"/></Box>
                <Box bg='#fff' height='30px'><Input placeholder='Last Name' size='lg' width="auto"/></Box>
                <Box bg='#fff' height='30px'><Input placeholder='Phone Number' size='lg' width="auto"/></Box>
                <Box bg='#fff' height='30px'><Input placeholder='Email Address' size='lg' width="auto"/></Box>
                <Box bg='#fff' height='30px'><Input size="x1" type="date"/></Box>
                <Box bg='#fff' height='30px'><Input size="x1" type="time"/></Box>
                <Box bg='#fff' height='30px'><Input placeholder='Number of Guests' size='lg' width="auto"/></Box>
                <Box bg='#fff' height='30px'></Box>
            </SimpleGrid>
            <SimpleGrid columns={1} spacing={20}>
                <Textarea placeholder='Special requests, dietary restrictions, or other notes.' />
            </SimpleGrid> */}